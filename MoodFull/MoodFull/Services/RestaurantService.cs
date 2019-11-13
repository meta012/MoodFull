using MoodFull.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoodFull.Services
{
    public class RestaurantService
    {
        //Method for getting restaurants
        //actually needs to get everything from database
        public static List<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>()
            {
                new Restaurant() {Name="Can Can"},
                new Restaurant() {Name="Express"},
                new Restaurant() {Name="Something Else"}
            };
            return restaurants;
        }
    }
}
