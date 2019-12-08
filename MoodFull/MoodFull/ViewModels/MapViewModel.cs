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
        public Xamarin.Forms.Maps.Map RestMap { get; private set; }
        public MapViewModel()
        {
            RestMap = new Xamarin.Forms.Maps.Map();

            var restaurantsServices = new RestaurantService();
            RestaurantsList = Task.Run(async () => await restaurantsServices.GetRestaurantsAsync()).Result;

            try
            {
                foreach (var restaurant in RestaurantsList)
                {
                    RestMap.Pins.Add(new Pin
                    {
                        Label = restaurant.Name,
                        Address = restaurant.Street + ", " + restaurant.City,
                        Position = new Position(restaurant.Latitude, restaurant.Longitude)
                    });
                }

                /*
                RestMap.Pins.Add(new Pin
                {
                    Label = "Kinu roze",
                    Address = "Kauno g. 15, Vilnius",
                    Position = new Position(54.672227, 25.2678866)
                });
                
                foreach (var place in PlacesList)
                {
                    RestMap.Pins.Add(new Pin
                    {
                        Label = place.Name,
                        Address = place.Street + ", " + place.City,
                        Position = new Position(place.Latitude, place.Longitude)
                    });
                }
                */


                //PlacesListView.ItemsSource = placesList;
                //var loc = Task.Run(async () => await Geolocation.GetLocationAsync()).Result;
                //var locator = CrossGeolocator.Current;
                //var position = Task.Run(async () => await locator.GetPositionAsync()).Result;
               
                RestMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(54.672227, 25.2700753), Distance.FromKilometers(0.5)));

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }



        /*
        private List<Restaurant> _restaurantList = new List<Restaurant>();
        public List<Restaurant> RestaurantsList
        {
            get { return _restaurantList; }
            set
            {
                _restaurantList = value;
                OnPropertyChanged();
            }
        }
        private List<Place> _restPlaces = new List<Place>();
        public List<Place> RestPlaces
        {
            get { return _restPlaces; }
            set
            {
                _restPlaces = value;
                OnPropertyChanged();
            }
        }
        public MapViewModel()
        {
            var restaurantsServices = new RestaurantService();
            //RestaurantsList = Task.Run(async () => await restaurantsServices.GetRestaurantsAsync()).Result;
            setPoints();
            getLocation();
            
        }
        private void setPoints()
        {
            RestPlaces.Add(new Place
                {
                    PlaceName = "Can can",
                    Address = "Kauno g. 15, Vilnius",
                    Position = new Position(54.6724716, 25.2726554)
                }); ;
        }
        
        
        private void setPoints()
        {
            foreach (var restaurant in RestaurantsList)
            {
                RestPlaces.Add(new Place
                {
                    PlaceName = restaurant.Name,
                    Address = restaurant.Street + ", " + restaurant.City,
                    Position = new Position(restaurant.Latitude, restaurant.Longitude)
                }); ;
            }
        }
        
        private void getLocation()
        {
            var locator = CrossGeolocator.Current;
            var position = Task.Run(async () => await locator.GetPositionAsync()).Result;
            var map = new Map { };
            map.MoveToRegion(MapSpan.FromCenterAndRadius(new
                Position(position.Latitude, position.Longitude),
                Distance.FromKilometers(2)));
        }
        */
    }
    
}
