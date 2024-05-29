using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    public interface IUserRepository
    {
        void Add(User user);
        void Update(User user);
        User Get(int id);
        void Delete(int id);
        List<User> GetAll();    
    }
}
