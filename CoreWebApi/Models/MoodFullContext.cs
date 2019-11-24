using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
                Name = "Can can"

            }, new Restaurant
            {
                RestaurantId = 2,
                Name = "Katpedele"
            });
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
        }
    }
}
