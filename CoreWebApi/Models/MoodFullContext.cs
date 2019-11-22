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
        }
    }
}
