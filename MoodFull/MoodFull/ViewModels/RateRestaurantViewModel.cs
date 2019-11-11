using System;
using System.Collections.Generic;
using System.Text;

namespace MoodFull.ViewModels
{
    public class RateRestaurantViewModel : BaseViewModel
    {
        private string _LabelText;

        public string LabelText
        {
            get { return _LabelText; }
            set { _LabelText = value; NotifyPropertyChanged("LabelText"); }
        }

        public RateRestaurantViewModel()
        {
            LabelText = "Page 1";
        }
    }
}
