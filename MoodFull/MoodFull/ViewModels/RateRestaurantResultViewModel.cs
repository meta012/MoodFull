using MoodFull.Interfaces;
using MoodFull.Models;
using MoodFull.MoodDetectors;
using MoodFull.Services;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace MoodFull.ViewModels
{
    public class RateRestaurantResultViewModel : BaseViewModel
    {
        // variables
        private byte[] _faceImage;
        private IMoodDetector _moodDetector;
        private ICalculateMood _calculateMood;
        private IEvaluationService evaluationServices;

        private MoodModel _moodModel;

        // get/set with dependent variables
        private ObservableCollection<Restaurant> _restaurantsList = new ObservableCollection<Restaurant>();
        public ObservableCollection<Restaurant> RestaurantsList
        {
            get { return _restaurantsList; }
            set
            {
                _restaurantsList = value;
                OnPropertyChanged(nameof(RestaurantsList));
            }
        }
        private Restaurant _selectedRestaurant;
        public Restaurant SelectedRestaurant
        {
            get
            {
                return _selectedRestaurant;
            }
            set
            {
                SetProperty(ref _selectedRestaurant, value);
            }
        }
        // sets property for the picker
        protected bool SetProperty<T>(ref T backfield, T value,
            [CallerMemberName]string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backfield, value))
            {
                return false;
            }
            backfield = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        // buttons commands
        public Command AddRestaurantCommand { get; }

        // constructor
        public RateRestaurantResultViewModel(byte[] faceImage, IMoodDetector moodDetector, ICalculateMood calculateMood)
        {
            this._faceImage = faceImage;
            this._moodDetector = moodDetector;
            this._calculateMood = calculateMood;

            //AddRestaurantCommand = new Command(async ()=> await AddRestaurant(), () => !IsWaiting);

            GetMood();
            SetRestaurants();
        }

        // gets mood from the picture
        private async void GetMood()
        {
            _moodModel = await _moodDetector.GetEmotions(_faceImage);
            CalculatedMood = _calculateMood.CalculateMood(_moodModel);
        }

        private bool _isWaiting = false;
        public bool IsWaiting
        {
            get
            {
                return _isWaiting;
            }
            set
            {
                _isWaiting = value;
                OnPropertyChanged();
                AddRestaurantCommand.ChangeCanExecute();
            }
        }

        // sets restaurants from database. Puts to observable-to be changed while in the same page
        private void SetRestaurants()
        {
            var restaurantServices = new RestaurantService();
            var restaurantsDbList = Task.Run(async () => await restaurantServices.GetRestaurantsAsync()).Result;
            foreach (Restaurant rest in restaurantsDbList)
            {
                RestaurantsList.Add(rest);
            }
        }

        // set/get, variables for the mood, exp and price
        private double _calculatedMood = 6;
        public double CalculatedMood
        {
            get
            {
                return _calculatedMood;
            }
            set
            {
                _calculatedMood = value;
                OnPropertyChanged();
            }
        }

        private double _experience = 5;
        public double Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                _experience = value;
                OnPropertyChanged();
            }
        }

        private double _price = 5;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }

        // evaluates restaurant
        public Command EvaluateCommand
        {
            get
            {
                return new Command(Evaluate);
            }
        }
        // evaluates restaurant only when current GPS is 100 meters apars
        private async void Evaluate()
        {
            if (_selectedRestaurant == null)
            {
                await Application.Current.MainPage.DisplayAlert("No restaurant is selected", "Please select a restaurant", "OK");
                return;
            }
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 10;
            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10));
            
            Location startLocation = new Location(position.Latitude, position.Longitude);
            Location endLocation = new Location(_selectedRestaurant.Latitude, _selectedRestaurant.Longitude);
            double distance = Location.CalculateDistance(startLocation, endLocation, DistanceUnits.Kilometers);
            if (distance > 0.1)
            {
                await Application.Current.MainPage.DisplayAlert("Restaurant is too far away", "Please change selected restaurant", "OK");
                return;
            }
            else
            {
                evaluationServices = ServiceFactory.GetEvaluationService();
                Evaluation newEvaluation = new Evaluation((decimal)_calculatedMood, (decimal)_price, (decimal)_experience, CurrentUser.UserID, _selectedRestaurant.RestaurantId);
                await evaluationServices.PostEvaluationAsync(newEvaluation);
                await Application.Current.MainPage.DisplayAlert("Success", "", "OK");
            }
        }

        /*
        // set/get, variables and Task to add restaurant to the DB
        private string _addRestaurantEntry;
        public string AddRestaurantEntry 
        {
            get
            {
                return _addRestaurantEntry;
            }
            set
            {
                _addRestaurantEntry = value;
                OnPropertyChanged();
            }
        }

        async Task AddRestaurant()
        {
            if (string.IsNullOrEmpty(AddRestaurantEntry))
            {
                await Application.Current.MainPage.DisplayAlert("Empty value", "Please enter Restaurant name", "OK");
                return;
            }

            bool choice = await Application.Current.MainPage.DisplayAlert("Confirm", $"Do you really want to add: {AddRestaurantEntry}", "Yes", "Cancel");

            if (!choice)
            {
                return;
            }

            //Lazy initialization of a RestaurantService
            Lazy<RestaurantService> restaurantService = new Lazy<RestaurantService>(() => new RestaurantService());

            var rest = new Restaurant();
            rest.Name = AddRestaurantEntry;

            //Clear entry field
            AddRestaurantEntry = "";

            await restaurantService.Value.PostRestaurantAsync(rest);
            
            // sets new restaurant to the picker
            SetRestaurants();
        }
        */
    }
}
