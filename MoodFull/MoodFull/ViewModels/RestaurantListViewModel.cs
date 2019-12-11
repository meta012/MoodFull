using System;
using System.Collections.Generic;
using System.Text;
using MoodFull.Models;
using System.Threading.Tasks;
using MoodFull.Services;
using System.Linq;
using MoodFull.Interfaces;
using MvvmHelpers;
using Xamarin.Forms;

namespace MoodFull.ViewModels
{
    class RestaurantListViewModel : BaseViewModel
    {
        private ObservableRangeCollection<Restaurant> _restaurantList = new ObservableRangeCollection<Restaurant>();
        private ObservableRangeCollection<Restaurant> _allRestaurantList = new ObservableRangeCollection<Restaurant>();
        private List<Restaurant> _restaurants = new List<Restaurant>();
        private ObservableRangeCollection<string> FilterOptions = new ObservableRangeCollection<string>();
        private IRestaurantService restaurantService;
        public RestaurantListViewModel()
        {
            Command LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }
        public ObservableRangeCollection<Restaurant> RestaurantList
        {
            get { return _restaurantList; }
            set
            {
                _restaurantList = value;
                OnPropertyChanged();
            }

        }
        public ObservableRangeCollection<Restaurant> AllRestaurantList
        {
            get { return _restaurantList; }
            set
            {
                _allRestaurantList = value;
                OnPropertyChanged();
            }

        }
        string _selectedFilter = "All";
        public string SelectedFilter
        {
            get { return  _selectedFilter; }
            set
            {
                _selectedFilter = value;
                    FilterItems();
               
            }
        }
        void FilterItems()
        {
            RestaurantList.ReplaceRange(AllRestaurantList.Where(a => a.Type == SelectedFilter || SelectedFilter == "All"));
        }

         async Task ExecuteLoadItemsCommand()
        {
            _restaurants = Task.Run(async () => await restaurantService.GetRestaurantsAsync()).Result;
            foreach (Restaurant x in _restaurants)
            {
                FilterOptions.Add(x.Type);
                RestaurantList.Add(x);
            }
             AllRestaurantList.ReplaceRange(RestaurantList);
                 FilterItems();

        }
    }
}
