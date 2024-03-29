﻿using MoodFull.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoodFull.Interfaces
{
    public interface IMoodDetector
    {
        Task<MoodModel> GetEmotions(byte[] byteArray);
    }
}
