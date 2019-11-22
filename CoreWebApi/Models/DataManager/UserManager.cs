using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApi.Models.Repository;

namespace CoreWebApi.Models.DataManager
{
    public class UserManager : IDataRepository<User>
    {
        readonly MoodFullContext _moodfullContext;

        public UserManager(MoodFullContext context)
        {
            _moodfullContext = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _moodfullContext.Users.ToList();
        }

        public User Get(long id)
        {
            return _moodfullContext.Users
                  .FirstOrDefault(e => e.UserId == id);
        }

        public void Add(User entity)
        {
            _moodfullContext.Users.Add(entity);
            _moodfullContext.SaveChanges();
        }

        public void Update(User user, User entity)
        {
            user.Username = entity.Username;
            user.Password = entity.Password;
            user.FirstName = entity.FirstName;
            user.LastName = entity.LastName;
            user.UserType = entity.UserType;

            _moodfullContext.SaveChanges();
        }

        public void Delete(User user)
        {
            _moodfullContext.Users.Remove(user);
            _moodfullContext.SaveChanges();
        }
    }
}
