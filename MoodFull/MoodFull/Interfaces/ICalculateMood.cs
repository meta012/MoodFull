using MoodFull.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoodFull.Interfaces
{
    public interface ICalculateMood
    {
        double CalculateMood(MoodModel moodModel);
    }
}
