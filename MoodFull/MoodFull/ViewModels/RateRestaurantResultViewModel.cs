using MoodFull.Interfaces;
using MoodFull.Models;
using MoodFull.MoodDetectors;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MoodFull.ViewModels
{
    public class RateRestaurantResultViewModel
    {
        private byte[] faceImage;
        private IMoodDetector moodDetector;

        private MoodModel moodModel;

        public RateRestaurantResultViewModel(byte[] faceImage)
        {
            this.faceImage = faceImage;
            moodDetector = new AzureMoodDetector();

            //Get Emotions button clicked
            GetEmotionsCommand = new Command(async () =>
            {
                //gets MoodModel with all moods from moodDetector
                moodModel = await moodDetector.GetEmotions(faceImage);
                var smth = moodModel;
            });
        }

        public Command GetEmotionsCommand { get; }

    }
}
