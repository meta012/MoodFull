using System;
using System.Collections.Generic;
using System.Text;
using MoodFull.Views;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;
using System.IO;
using MoodFull.Models;
using MoodFull.Services;
using MoodFull.Interfaces;

namespace MoodFull.ViewModels
{
    public class RatedRestaurantsViewModel : BaseViewModel
    {
        private List<Evaluation> _evaluationList = new List<Evaluation>();
        private List<Restaurant> _restaurantList = new List<Restaurant>();
        private List<User> _usersList = new List<User>();
        private List<MergedObject> _mergedList = new List<MergedObject>();
        private IListService listService = new ListService();

        public RatedRestaurantsViewModel()
        {;
            listService.SetMergedList(MergedList);
            
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
    }
}
