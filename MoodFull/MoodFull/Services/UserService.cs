using MoodFull.RestClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MoodFull.Models;

namespace MoodFull.Services
{
    public class UserService
    {
        private const string userUrl = "Users";
        //Gauna userius
        public async Task<List<User>> GetUsersAsync()
        {
            RestClient<User> restClient = new RestClient<User>();
            var usersList = await restClient.GetAsync(userUrl);
            return usersList;
        }

        //Gauna viena useri pagal id
        public async Task<User> GetUserAsync(long id)
        {
            RestClient<User> restClient = new RestClient<User>();
            var user = await restClient.GetAsync(id, userUrl);
            return user;
        }

        //Insertina nauja useri
        public async Task PostUserAsync(User user)
        {
            RestClient<User> restClient = new RestClient<User>();
            var isSuccess = await restClient.PostAsync(user, userUrl);
        }

        //Upadtina esama useri. 
        public async Task PutUserAsync(long id, User user)
        {
            RestClient<User> restClient = new RestClient<User>();
            var isSuccess = await restClient.PutAsync(id, user, userUrl);
        }
        public async Task DeleteUserAsync(long id)
        {
            RestClient<User> restClient = new RestClient<User>();
            var isSuccess = await restClient.DeleteAsync(id, userUrl);
        }
    }
}
