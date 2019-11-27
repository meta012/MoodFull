﻿using MoodFull.Interfaces;
using MoodFull.Models;
using MoodFull.MoodDetectors;
using MoodFull.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MoodFull.ViewModels
{
    public class RateRestaurantResultViewModel : BaseViewModel
    {
        // variables
        private byte[] faceImage;
        private IMoodDetector moodDetector;
        private ICalculateMood calculateMood;

        private MoodModel moodModel;

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
        private Restaurant selectedRestaurant;
        public Restaurant SelectedRestaurant
        {
            get
            {
                return selectedRestaurant;
            }
            set
            {
                SetProperty(ref selectedRestaurant, value);
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
            this.faceImage = faceImage;
            this.moodDetector = moodDetector;// new AzureMoodDetector();
            this.calculateMood = calculateMood;

            AddRestaurantCommand = new Command(async ()=> await AddRestaurant(), () => !IsWaiting);

            GetMood();
            SetRestaurants();
        }

        // gets mood from the picture
        private async void GetMood()
        {
            moodModel = await moodDetector.GetEmotions(faceImage);
            CalculatedMood = calculateMood.CalculateMood(moodModel);
        }

        private bool isWaiting = false;
        public bool IsWaiting
        {
            get
            {
                return isWaiting;
            }
            set
            {
                isWaiting = value;
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
            RestaurantsList.OrderByDescending(c => c.Name);
        }

        // set/get, variables for the mood, exp and price

        private double calculatedMood = 6;
        public double CalculatedMood
        {
            get
            {
                return calculatedMood;
            }
            set
            {
                calculatedMood = value;
                OnPropertyChanged();
            }
        }

        private double experience = 5;
        public double Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
                OnPropertyChanged();
            }
        }

        private double price = 5;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                OnPropertyChanged();
            }
        }

        // evaluates restaurant

        public Command EvaluateRestaurant
        {
            get
            {
                return new Command(Evaluate);
            }
        }
        private void Evaluate()
        {
            var evaluationServices = new EvaluationService();
            Evaluation newEvaluation = new Evaluation((decimal)calculatedMood, (decimal)price, (decimal)experience, CurrentUser.UserID, selectedRestaurant.RestaurantId);
            Task.Run(async () => await evaluationServices.PostEvaluationAsync(newEvaluation));
            Application.Current.MainPage.DisplayAlert("Success", "", "OK");
        }

        // set/get, variables and Task to add restaurant to the DB
        private string addRestaurantEntry;
        public string AddRestaurantEntry 
        {
            get
            {
                return addRestaurantEntry;
            }
            set
            {
                addRestaurantEntry = value;
                OnPropertyChanged();
            }
        }

        async Task AddRestaurant()
        {
            if(string.IsNullOrEmpty(AddRestaurantEntry))
            {
                await Application.Current.MainPage.DisplayAlert("Empty value", "Please enter Restaurant name", "OK");
                return;
            }

            bool choice = await Application.Current.MainPage.DisplayAlert("Confirm", $"Do you really want to add: {AddRestaurantEntry}", "Yes", "Cancel");

            if(!choice)
            {
                return;
            }

            var restaurantServices = new RestaurantService();

            var rest = new Restaurant();
            rest.Name = AddRestaurantEntry;

            //Clear entry field
            AddRestaurantEntry = "";

            await restaurantServices.PostRestaurantAsync(rest);
            
            // sets new restaurant to the picker
            SetRestaurants();
        }
    }
}
