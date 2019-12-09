using GoogleMaps.LocationServices;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{

    //CHANGE APPSETTINGS.JSON folder, that database is in

    public class MoodFullContext : DbContext
    {
        public MoodFullContext(DbContextOptions options)
            :base(options)
        {

        }
        private static long incrementedId = 100;
        private long expectedId = 0;
        public DbSet<User> Users { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 1,
                Username = "admin",
                Password = "admin",
                FirstName = "admin",
                LastName = "admin",
                UserType = 1
            }, new User
            {
                UserId = 2,
                Username = "labas",
                Password = "labaslabas",
                FirstName = "labas",
                LastName = "lab",
                UserType = 2
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantId = 1,
                Name = "TESTER Algirdo",
                Url = "TESTER.com",
                Type = "TESTER",
                Street = "Algirdo g. 53",
                SpecifyStreet = null,
                City = "Vilnius",
                Country = "Lithuania",
                Latitude = 54.6724131,
                Longitude = 25.2729935,

            }, new Restaurant
            {
                RestaurantId = 2,
                Name = "TESTER Didlaukio",
                Url = "TESTER.com",
                Type = "TESTER",
                Street = "Didlaukio g. 47",
                SpecifyStreet = null,
                City = "Vilnius",
                Country = "Lithuania",
                Latitude = 54.7296485,
                Longitude = 25.2640115,
            }
            );
            modelBuilder.Entity<Evaluation>().HasData(new Evaluation
            {
                EvaluationId = 1,
                MoodRating = (decimal)4.20,
                Price = (decimal)1.50,
                Experience = (decimal)3.3,
                UserId = 1,
                RestaurantId = 1

            }, new Evaluation
            {
                EvaluationId = 2,
                MoodRating = (decimal)1.55,
                Price = (decimal)6.23,
                Experience = (decimal)4.23,
                UserId = 2,
                RestaurantId = 2
            });
            /*
            // functions to add json file to the database and convert addresses to latitude+longitude
            var restaurants = new List<Restaurant>();
            using (StreamReader r = new StreamReader("D:/Users/meta/Desktop/Mood/objProject/CoreWebApi/Vilnius_restaurants.json"))
            {
                string json = r.ReadToEnd();
                restaurants = JsonConvert.DeserializeObject<List<Restaurant>>(json);
            }
            foreach (var restaurant in restaurants)
            {
                var address = restaurant.Street + ", " + restaurant.City;
                // Add your google Api key
                var locationService = new GoogleLocationService(apikey: "Api_Key");
                var point = locationService.GetLatLongFromAddress(address);
                this.expectedId = incrementedId;

                modelBuilder.Entity<Restaurant>().HasData(new Restaurant
                {
                    RestaurantId = this.expectedId,
                    Name = restaurant.Name,
                    Url = restaurant.Url,
                    Type = restaurant.Type,
                    Street = restaurant.Street,
                    SpecifyStreet = restaurant.SpecifyStreet,
                    City = restaurant.City,
                    Country = restaurant.Country,
                    Latitude = point.Latitude,
                    Longitude = point.Longitude,
                });
                incrementedId++;
            }
            */
        }
    }
}
