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
    public partial class UsersRatedRestaurants : ContentPage
    {
        public UsersRatedRestaurants()
        {
            InitializeComponent();
            BindingContext = new UsersRatedRestaurantsViewModel();
        }
        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var vm = BindingContext as UsersRatedRestaurantsViewModel;
            UsersEvaluationListsView.BeginRefresh();
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                UsersEvaluationListsView.ItemsSource = vm.UsersEvaluations;
            else
                UsersEvaluationListsView.ItemsSource = vm.UsersEvaluations.Where(i => i.RestaurantName.ToLower().Contains(e.NewTextValue.ToLower()));

            UsersEvaluationListsView.EndRefresh();



        }
    }
}