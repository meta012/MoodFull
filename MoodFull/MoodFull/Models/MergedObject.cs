using System;
using System.Collections.Generic;
using System.Text;

namespace MoodFull.Models
{
    public class MergedObject
    {
        public long RestaurantId { get; set; }
        public decimal MoodRating { get; set; }
        public decimal Price { get; set; }
        public decimal Experience { get; set; }
        public string RestaurantName { get; set; }
        public string Username { get; set; }
        public long UserId { get; set; }

        public MergedObject(long restId, string username, decimal rating, decimal price, decimal experience, string restaurantName, long userId)
        {
            RestaurantId = restId;
            Username = username;
            MoodRating = rating;
            Price = price;
            Experience = experience;
            RestaurantName = restaurantName;
            UserId = userId;
        }
        public MergedObject(decimal rating, decimal price, decimal experience, string restaurantName)
        {
            
            MoodRating = rating;
            Price = price;
            Experience = experience;
            RestaurantName = restaurantName;
            
        }
    }
}
