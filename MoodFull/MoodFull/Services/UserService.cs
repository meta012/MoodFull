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
        public async Task<List<User>> GetUsersAsync()
        {
            RestClient<User> restClient = new RestClient<User>();
            var usersList = await restClient.GetAsync();
            return usersList;
        }
        public async Task PostUserAsync(User user)
        {
            RestClient<User> restClient = new RestClient<User>();
            var isSuccess = await restClient.PostAsync(user);
        }
        public async Task PutUserAsync(long id, User user)
        {
            RestClient<User> restClient = new RestClient<User>();
            var isSuccess = await restClient.PutAsync(id, user);
        }
        public async Task DeleteUserAsync(long id)
        {
            RestClient<User> restClient = new RestClient<User>();
            var isSuccess = await restClient.DeleteAsync(id);
        }
    }
}
