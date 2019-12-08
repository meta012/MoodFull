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

            //List for navigation items
            menuList = new List<MasterPageItem>();

            //Add pages to the navigation bar
            var page1 = new MasterPageItem() { Title = "Rate Restaurant", TargetType = typeof(Views.RateRestaurant) };
            var page2 = new MasterPageItem() { Title = "Rated Restaurants", TargetType = typeof(Views.RatedRestaurants) };
            var page3 = new MasterPageItem() { Title = "Top User", TargetType = typeof(Views.TopUserPage) };
            var page4 = new MasterPageItem() { Title = "User's Evaluations", TargetType = typeof(Views.UsersRatedRestaurants) };
            var page5 = new MasterPageItem() { Title = "Restaurants average evaluations", TargetType = typeof(Views.RestaurantsAverageEvaluations) };
            var page6 = new MasterPageItem() { Title = "Mapped restaurants", TargetType = typeof(Views.MapPage) };

            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);
            menuList.Add(page5);
            menuList.Add(page6);

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
