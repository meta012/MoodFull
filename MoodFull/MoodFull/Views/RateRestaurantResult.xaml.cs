using MoodFull.MoodDetectors;
using MoodFull.Services;
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
	public partial class RateRestaurantResult : ContentPage
	{
		public RateRestaurantResult (byte[] faceImage)
		{
			InitializeComponent ();
            BindingContext = new ViewModels.RateRestaurantResultViewModel(faceImage, new AzureMoodDetector(), new CalculateMoodService());
        }
	}
}