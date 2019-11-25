using System;
using System.Collections.Generic;
using System.Text;
using MoodFull.Models;

namespace MoodFull.Mocks
{
   
   public static class DataCollections
    {
        /// <summary>
        /// Checks if given user exists with given username and password in the list
        /// </summary>
        /// <param name="username">User usrname to find</param>
        /// <param name="password"> User password to find</param>
        /// <param name="userList"> List where to search</param>
        /// <returns> return true if given password matches with user in the list</returns>
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

        public static int GetUserID(string username, string password, List<User> userList)
        {
            foreach (var item in userList)
            {
                if (item.Username == username && item.Password == password)
                {
                    //return item.id;
                }
            }
            return -1;
        }
    }
}
