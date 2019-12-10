using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using MoodFull.Services;
using MoodFull.Models;
using MoodFull.Interfaces;

namespace MoodFull.ViewModels
{
    class UsersRatedRestaurantsViewModel : BaseViewModel
    {
        private List<MergedObject> _usersEvaluations = new List<MergedObject>();
        IListService listService = new ListService();

        public UsersRatedRestaurantsViewModel()
        {
            listService.SetMergedList(UsersEvaluations);
            UsersEvaluations= listService.SetUsersEvaluations(UsersEvaluations);
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
