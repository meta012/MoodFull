using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApi.Models.Repository;

namespace CoreWebApi.Models.DataManager
{
    public class RestaurantManager : IDataRepository<Restaurant>
    {
        readonly MoodFullContext _moodfullContext;

        public RestaurantManager(MoodFullContext context)
        {
            _moodfullContext = context;
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _moodfullContext.Restaurants.ToList();
        }

        public Restaurant Get(long id)
        {
            return _moodfullContext.Restaurants
                  .FirstOrDefault(e => e.RestaurantId == id);
        }

        public void Add(Restaurant entity)
        {
            _moodfullContext.Restaurants.Add(entity);
            _moodfullContext.SaveChanges();
        }

        public void Update(Restaurant restaurant, Restaurant entity)
        {
            restaurant.Name = entity.Name;

            _moodfullContext.SaveChanges();
        }

        public void Delete(Restaurant restaurant)
        {
            _moodfullContext.Restaurants.Remove(restaurant);
            _moodfullContext.SaveChanges();
        }
    }
}
