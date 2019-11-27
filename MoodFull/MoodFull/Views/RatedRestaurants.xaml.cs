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
	public partial class RatedRestaurants : ContentPage
	{
		public RatedRestaurants ()
		{
			InitializeComponent ();
			BindingContext = new ViewModels.RatedRestaurantsViewModel();
		}
	}
}
