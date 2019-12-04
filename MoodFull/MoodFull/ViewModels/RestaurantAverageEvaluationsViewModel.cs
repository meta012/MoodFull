using System;
using System.Collections.Generic;
using System.Text;
using MoodFull.Models;
using System.Threading.Tasks;
using MoodFull.Services;
using System.Linq;

namespace MoodFull.ViewModels
{
    class RestaurantAverageEvaluationsViewModel : BaseViewModel
    {
        private List<MergedObject> _restaurantsEvaluations = new List<MergedObject>();

        public RestaurantAverageEvaluationsViewModel()
        {
            var listServices = new ListService();
            listServices.SetMergedList(RestaurantsEvaluations);
            RestaurantsEvaluations = listServices.SetRestaurantsAverageEvaluations(RestaurantsEvaluations);
            
        }
        public List<MergedObject> RestaurantsEvaluations
        {
            get { return _restaurantsEvaluations; }
            set
            {
                _restaurantsEvaluations = value;
                OnPropertyChanged();
            }
        }
    }
}
