using System;
using System.Collections.Generic;
using System.Text;

namespace MoodFull.Models
{
    //Saves current UserID for identity check
    static class CurrentUser
    {
        private static int userID;
        public static int UserID { get => userID; set => userID = value; }
    }
}
