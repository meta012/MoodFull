using System;
using System.Collections.Generic;
using System.Text;

namespace MoodFull.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserType { get; set; }
        public int UserID { get; set; }
    }
}
