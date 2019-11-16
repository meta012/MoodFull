using MoodFull.Interfaces;
using MoodFull.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoodFull.Services
{
    class CalculateMoodService : ICalculateMood
    {
        public double CalculateMood(MoodModel moodModel)
        {
            //calculate score need implementations
            return moodModel.faceAttributes.emotion.neutral;
        }
    }
}
