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
	public partial class RatedRestaurants : ContentPage
	{
		public RatedRestaurants ()
		{
			InitializeComponent ();
			BindingContext = new ViewModels.RatedRestaurantsViewModel();
		}
        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var vm = BindingContext as RatedRestaurantsViewModel;
            MergedListListsView.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                MergedListListsView.ItemsSource = vm.MergedList;
            else
                MergedListListsView.ItemsSource = vm.MergedList.Where(i => i.RestaurantName.ToLower().Contains(e.NewTextValue.ToLower()));

            MergedListListsView.EndRefresh();

        }
        private void SearchBar_OnTextChanged1(object sender, TextChangedEventArgs e)
        {
            var vm = BindingContext as RatedRestaurantsViewModel;
            MergedListListsView.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                MergedListListsView.ItemsSource = vm.MergedList;
            else
                MergedListListsView.ItemsSource = vm.MergedList.Where(i => i.Username.ToLower().Contains(e.NewTextValue.ToLower()));

            MergedListListsView.EndRefresh();

        }
    }
}
