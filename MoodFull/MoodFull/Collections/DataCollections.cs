using System;
using System.Collections.Generic;
using System.Text;
using MoodFull.Models;

namespace MoodFull.Mocks
{
   
   public static class DataCollections
    {

        public static bool UserExists(string username, string password, List<User> userList)
        {
            foreach (var item in userList)
            {
                if (item.Username == username && item.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public static void AddUser(string username,string password, string name,string lastname)
        {
           
        }
    }
}
