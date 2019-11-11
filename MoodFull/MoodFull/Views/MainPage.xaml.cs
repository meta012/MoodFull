using MoodFull.Models;
using MoodFull.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MoodFull
{
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> menuList { get; set; }

        public MainPage()
        {
            InitializeComponent();

            menuList = new List<MasterPageItem>();

            //Add items to the navigation bar
            var page1 = new MasterPageItem() { Title = "Rate Restaurant", TargetType = typeof(Views.RateRestaurant) };
            var page2 = new MasterPageItem() { Title = "Rated Restaurants", TargetType = typeof(Views.RatedRestaurants) };

            menuList.Add(page1);
            menuList.Add(page2);

            NavigationList.ItemsSource = menuList;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Views.RateRestaurant)));
        }

        //Opens page which was selected on navigation bar
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
