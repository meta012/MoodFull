using MoodFull.RestClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MoodFull.Models;
using MoodFull.Interfaces;

namespace MoodFull.Services
{
    public class RestaurantService: IRestaurantService
    {
        private const string restaurantUrl = "Restaurants";
        //Gauna restoranus
        public async Task<List<Restaurant>> GetRestaurantsAsync()
        {
            RestClient<Restaurant> restClient = new RestClient<Restaurant>();
            var restaurantsList = await restClient.GetAsync(restaurantUrl);
            return restaurantsList;
        }

        //Gauna viena restorana pagal id
        public async Task<Restaurant> GetRestaurantAsync(long id)
        {
            RestClient<Restaurant> restClient = new RestClient<Restaurant>();
            var restaurant = await restClient.GetAsync(id, restaurantUrl);
            return restaurant;
        }

        //Insertina nauja restorana
        public async Task PostRestaurantAsync(Restaurant restaurant)
        {
            RestClient<Restaurant> restClient = new RestClient<Restaurant>();
            var isSuccess = await restClient.PostAsync(restaurant, restaurantUrl);
        }

        //Upadtina esama restorana. 
        public async Task PutRestaurantAsync(long id, Restaurant restaurant)
        {
            RestClient<Restaurant> restClient = new RestClient<Restaurant>();
            var isSuccess = await restClient.PutAsync(id, restaurant, restaurantUrl);
        }
        public async Task DeleteRestaurantAsync(long id)
        {
            RestClient<Restaurant> restClient = new RestClient<Restaurant>();
            var isSuccess = await restClient.DeleteAsync(id, restaurantUrl);
        }
    }
}