using MoodFull.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoodFull.Services
{
    public class MockRestaurantService
    {
        //Method for getting restaurants
        //actually needs to get everything from database
        public static List<MockRestaurant> GetRestaurants()
        {
            var restaurants = new List<MockRestaurant>()
            {
                new MockRestaurant() {Name="Can Can"},
                new MockRestaurant() {Name="Express"},
                new MockRestaurant() {Name="Something Else"}
            };
            return restaurants;
        }
    }
}
