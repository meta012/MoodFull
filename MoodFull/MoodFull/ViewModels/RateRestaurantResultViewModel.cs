using MoodFull.Interfaces;
using MoodFull.Models;
using MoodFull.MoodDetectors;
using MoodFull.Services;
using System;
using System.Collections.Generic;
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
        private byte[] faceImage;
        private IMoodDetector moodDetector;
        private ICalculateMood calculateMood;

        private MoodModel moodModel;

        public List<Restaurant> RestaurantList { get; set; }

        public Command GetEmotionsCommand { get; }

        public RateRestaurantResultViewModel(byte[] faceImage, IMoodDetector moodDetector, ICalculateMood calculateMood)
        {
            this.faceImage = faceImage;
            this.moodDetector = moodDetector;// new AzureMoodDetector();
            this.calculateMood = calculateMood;

            //Get Emotions button clicked
            GetEmotionsCommand = new Command(async ()=> await GetMood(), () => !IsWaiting);

            RestaurantList = RestaurantService.GetRestaurants().OrderBy(c => c.Name).ToList();
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
                GetEmotionsCommand.ChangeCanExecute();
            }
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
                GetEmotionsCommand.ChangeCanExecute();
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

        async Task GetMood()
        {
            IsWaiting = true;
            //for whatever reason without Task.Delay(1) the ActivityIndicator isn't working
            await Task.Delay(1);
            moodModel = await moodDetector.GetEmotions(faceImage);
            CalculatedMood = calculateMood.CalculateMood(moodModel);
            IsWaiting = false;
        }

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
    }
}
