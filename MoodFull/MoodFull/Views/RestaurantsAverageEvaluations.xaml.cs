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
            BindingContext = new ViewModels.RestaurantAverageEvaluationsViewModel();
        }
    }
}