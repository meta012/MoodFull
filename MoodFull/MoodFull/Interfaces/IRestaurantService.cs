using System;
using System.Collections.Generic;
using System.Text;
using MoodFull.Models;
using System.Threading.Tasks;

namespace MoodFull.Interfaces
{
    interface IRestaurantService
    {
        ///Esamas restoranas = Pagal jo ID

        //Gauna restoranu sarasa
        Task<List<Restaurant>> GetRestaurantsAsync();

        //Gauna viena restorana pagal id
        Task<Restaurant> GetRestaurantAsync(long id);

        //Ideda nauja restorana
        Task PostRestaurantAsync(Restaurant restaurant);

        //Upadtina esama restorana. 
        Task PutRestaurantAsync(long id, Restaurant restaurant);

        //Istrina esama restorana
        Task DeleteRestaurantAsync(long id);

    }
}
