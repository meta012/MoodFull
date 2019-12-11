using System;
using System.Collections.Generic;
using System.Text;
using MoodFull.Models;
using System.Threading.Tasks;
using MoodFull.Services;
using System.Linq;
using MoodFull.Interfaces;

namespace MoodFull.ViewModels
{
    class RestaurantAverageEvaluationsViewModel : BaseViewModel
    {
        private List<MergedObject> _restaurantsEvaluations = new List<MergedObject>();
        private IListService listService = ServiceFactory.GetListService();

        public RestaurantAverageEvaluationsViewModel()
        {
            listService.SetMergedList(RestaurantsEvaluations);
            RestaurantsEvaluations = listService.SetRestaurantsAverageEvaluations(RestaurantsEvaluations); 
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
