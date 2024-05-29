using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    public class UserRepository:IUserRepository
    {
        private List<User> _users = new List<User>();

        public void Add(User user)
        {
            _users.Add(user);
        }

        public void Delete(int id)
        {
            var user=_users.Find(m=>m.ID==id);
            if (user != null)
            {
                _users.Remove(user);
            }
        }

        public User Get(int id)
        {
            return _users.FirstOrDefault(m => m.ID == id);
        }

        public List<User> GetAll()
        {
            return _users;
        }

        public void Update(User user)
        {
            var newUser=_users.Find(m=>m.ID==user.ID);
            if (newUser != null)
            {
                newUser.Name=user.Name;
                newUser.Email=user.Email;
            }
        }
    }
}
