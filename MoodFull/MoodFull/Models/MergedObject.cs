using System;
using System.Collections.Generic;
using System.Text;

namespace MoodFull.Models
{
    class MergedObject
    {
        public decimal MoodRating { get; set; }
        public decimal Price { get; set; }
        public decimal Experience { get; set; }
        public string RestaurantName { get; set; }
        public string Username { get; set; }

        public MergedObject(string username, decimal rating, decimal price, decimal experience, string restaurantName)
        {
            Username = username;
            MoodRating = rating;
            Price = price;
            Experience = experience;
            RestaurantName = restaurantName;
        }
    }
}
