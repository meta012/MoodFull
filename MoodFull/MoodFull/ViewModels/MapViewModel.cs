using MoodFull.Models;
using MoodFull.Services;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;
using Xamarin.Essentials;
using Xamarin.Forms;
using MoodFull.CustomizedMap;

namespace MoodFull.ViewModels
{
    public class MapViewModel : BaseViewModel
    {

        List<Restaurant> _restaurantsList = new List<Restaurant>();
        public List<Restaurant> RestaurantsList
        {
            get { return _restaurantsList; }
            set
            {
                _restaurantsList = value;
                OnPropertyChanged();
            }
        }
        public CustomMap RestMap { get; private set; }
        public MapViewModel()
        {
            RestMap = new CustomMap();

            var restaurantsServices = new RestaurantService();
            RestaurantsList = Task.Run(async () => await restaurantsServices.GetRestaurantsAsync()).Result;

            try
            {
                foreach (var restaurant in RestaurantsList)
                {
                    CustomPin pin = new CustomPin
                    {
                        Label = restaurant.Name,
                        Address = restaurant.Street + ", " + restaurant.City,
                        Position = new Position(restaurant.Latitude, restaurant.Longitude),
                        Name = "Xamarin",
                        Url = "XamarinUrl"
                    };
                    RestMap.CustomPins = new List<CustomPin> { pin };
                    RestMap.Pins.Add(pin);
                }
                setCurrentPosition();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        private async void setCurrentPosition()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 10;
            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10));
               
            RestMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(position.Latitude, position.Longitude), Distance.FromKilometers(0.5)));
            RestMap.Pins.Add(new CustomPin
            {
                Label = "Your current possition",
                Address = null,
                Position = new Position(position.Latitude, position.Longitude),
                Name = "xamarin",
                Url = "xamUrl"
            });;        
        }
    }
    
}
