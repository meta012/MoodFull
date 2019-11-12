using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoodFull.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RateRestaurant : ContentPage
	{
		public RateRestaurant ()
		{
			InitializeComponent ();
            BindingContext = new ViewModels.RateRestaurantViewModel();
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RateRestaurant());
            //Application.Current.MainPage = new NavigationPage(new Page4());
        }
    }
}