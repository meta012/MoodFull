using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodFull.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoodFull.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestaurantsAverageEvaluations : ContentPage
    {
        public RestaurantsAverageEvaluations()
        {   
            InitializeComponent();
            BindingContext = new RestaurantAverageEvaluationsViewModel();
        }
        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var vm = BindingContext as RestaurantAverageEvaluationsViewModel;
            RestaurantsEvaluationListsView.BeginRefresh();
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                RestaurantsEvaluationListsView.ItemsSource = vm.RestaurantsEvaluations;
            else
                RestaurantsEvaluationListsView.ItemsSource = vm.RestaurantsEvaluations.Where(i => i.RestaurantName.ToLower().Contains(e.NewTextValue.ToLower()));

            RestaurantsEvaluationListsView.EndRefresh();
        }
    }
}