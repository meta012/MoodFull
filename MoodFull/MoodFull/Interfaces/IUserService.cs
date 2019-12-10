using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MoodFull.Models;

namespace MoodFull.Interfaces
{
    interface IUserService
    {
        //Gauna user sarasa
        Task<List<User>> GetUsersAsync();

        //Gauna user pagal jo ID
        Task<User> GetUserAsync(long id);

        //Insertina nauja user
        Task PostUserAsync(User user);

        //Updatina esama user. Suranda DB-eje pagal ID
        Task PutUserAsync(long id, User user);

        //Istrina esama user. Suranda DB-eje pagal ID
        Task DeleteUserAsync(long id);
    }
}
