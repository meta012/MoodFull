using System;
using System.Collections.Generic;
using System.Text;

namespace MoodFull.Models
{
    //Saves current UserID for identity check
    static class CurrentUser
    {
        public static long UserID { get ; set ; }
    }
}
