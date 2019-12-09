using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace MoodFull.Models
{
    public class Restaurant
    {
        public long RestaurantId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public string Street { get; set; }
        public string SpecifyStreet { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string NameStreet
        {
            get { return Name + ", "+ Street; }
            set { }
        }
    }
}
