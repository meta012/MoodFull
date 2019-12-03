using System;
using System.Collections.Generic;
using System.Text;
using MoodFull.Models;
using System.Linq;
using System.Threading.Tasks;
using MoodFull.Services;

namespace MoodFull.Services
{
    class ListService
    {
        private List<Evaluation> _evaluationList = new List<Evaluation>();
        private List<Restaurant> _restaurantList = new List<Restaurant>();
        private List<User> _usersList = new List<User>();

        public List<MergedObject> SetMergedList(List<MergedObject> mergedList)
        {
            var usersServices = new UserService();
            var restaurantServices = new RestaurantService();
            var evaluationServices = new EvaluationService();
            _usersList = Task.Run(async () => await usersServices.GetUsersAsync()).Result;
            _restaurantList = Task.Run(async () => await restaurantServices.GetRestaurantsAsync()).Result;
            _evaluationList = Task.Run(async () => await evaluationServices.GetEvaluationsAsync()).Result;
            var list = (from m1 in _usersList
                        join m2 in _evaluationList on m1.UserId equals m2.UserId
                        select new { m1.Username, m2.MoodRating, m2.Price, m2.Experience, m2.RestaurantId, m1.UserId } into temp
                        join m3 in _restaurantList on temp.RestaurantId equals m3.RestaurantId
                        select new { temp.Username, temp.MoodRating, temp.Price, temp.Experience, m3.Name, temp.UserId }).ToList();
            foreach (var x in list)
            {
                mergedList.Add(new MergedObject(x.Username, x.MoodRating, x.Price, x.Experience, x.Name, x.UserId));
            }
            return mergedList;
        }
        public List<MergedObject> SetUsersEvaluations (List<MergedObject> mergedList)
        {
            List<MergedObject> usersEvaluationList = new List<MergedObject>();
            foreach (MergedObject x in mergedList)
            {
                if(x.UserId==CurrentUser.UserID)
                {
                    usersEvaluationList.Add(x);
                }
                Console.WriteLine(x.UserId);
            }
            Console.WriteLine(CurrentUser.UserID);
            return usersEvaluationList;
        }
    }
}
