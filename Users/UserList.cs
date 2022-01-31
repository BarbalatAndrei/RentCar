using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Users
{
    public class UserList
    {
        public List<User> users = new List<User>();
        public User user1 = new User();
        public User admin = new User();

        public List<User> GetUsers()
        {
            user1.username = "victor";
            user1.password = "victor";

            admin.username = "admin";
            admin.password = "admin";

            users.Add(user1);
            users.Add(admin);

            return users;
        }
        
    }
}
