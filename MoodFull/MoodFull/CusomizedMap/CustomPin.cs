using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MoodFull.CustomizedMap
{
    public class CustomPin : Pin
    {
        public decimal MoodRating { get; set; }
        public string Url { get; set; }
    }
}
