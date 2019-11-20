using System;
using System.Collections.Generic;
using System.Text;

namespace MoodFull.Mocks
{
   
   public static class DataCollections
    {
        public static List<Rating> ratings = new List<Rating>();
        public static List<User> userList = new List<User>{new User("admin", "admin" ,"admin", "admin")};

        public static bool UserExists(string username, string password)
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
            userList.Add(new User(username, password, name, lastname));
        }
    }
}
