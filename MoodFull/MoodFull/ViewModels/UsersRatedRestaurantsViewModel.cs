using System;
using System.Collections.Generic;
using System.Text;
using MoodFull.Models;
using System.Threading.Tasks;
using MoodFull.Services;
using System.Linq;

namespace MoodFull.ViewModels
{
    class UsersRatedRestaurantsViewModel : BaseViewModel
    {
        
        private List<MergedObject> _usersEvaluations = new List<MergedObject>();

        public UsersRatedRestaurantsViewModel()
        {
            var listServices = new ListService();
            listServices.SetMergedList(UsersEvaluations);
            UsersEvaluations=listServices.SetUsersEvaluations(UsersEvaluations);
        }
        public List<MergedObject> UsersEvaluations
        {
            get { return _usersEvaluations; }
            set
            {
                _usersEvaluations = value;
                OnPropertyChanged();
            }
        }

       
    }
}
