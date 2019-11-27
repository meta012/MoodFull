using System;
using System.Collections.Generic;
using System.Text;
using MoodFull.Views;
using MoodFull.Models;
using System.Threading.Tasks;
using MoodFull.Services;
using System.Linq;
using System.Collections;
using System.IO;

namespace MoodFull.ViewModels
{
    class RatedRestaurantsViewModel : BaseViewModel
    {
        private List<Evaluation> _evaluationList = new List<Evaluation>();
        private List<Restaurant> _restaurantList = new List<Restaurant>();
        private List<User> _usersList = new List<User>();
        private List<MergedObject> _mergedList = new List<MergedObject>();
        

        public RatedRestaurantsViewModel()
        {

        }
        
        public List<User> UsersList
        {
            get { return _usersList; }
            set
            {
                _usersList = value;
                OnPropertyChanged();
            }
        }

        public List<Restaurant> RestaurantList
        {
            get { return _restaurantList; }
            set
            {
                _restaurantList = value;
                OnPropertyChanged();
            }
        }

        public List<Evaluation> EvaluationList
        {
            get { return _evaluationList; }
            set
            {
                _evaluationList = value;
                OnPropertyChanged();
            }
        }
        public List<MergedObject> MergedList
        {
            get { return _mergedList; }
            set
            {
                _mergedList = value;
                OnPropertyChanged();
            }
        }
        
        private async Task InitializeDataAsync()
        {
            var usersServices = new UserService();
            var restaurantServices = new RestaurantService();
            var evaluationServices = new EvaluationService();
            UsersList = await usersServices.GetUsersAsync();
            RestaurantList = await restaurantServices.GetRestaurantsAsync();
            EvaluationList = await evaluationServices.GetEvaluationsAsync();
            var list = (from m1 in UsersList
                              join m2 in EvaluationList on m1.UserId equals m2.UserId
                              select new { m1.Username, m2.MoodRating, m2.Price, m2.Experience, m2.RestaurantId } into temp
                              join m3 in RestaurantList on temp.RestaurantId equals m3.RestaurantId
                              select new { temp.Username, temp.MoodRating, temp.Price, temp.Experience, m3.Name }).ToList();
            foreach (var x in list)
            {
                MergedList.Add(new MergedObject(x.Username, x.MoodRating, x.Price, x.Experience, x.Name));
            }
            
        }

    }
}
