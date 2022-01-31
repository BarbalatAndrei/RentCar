using RentCar.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Connection
{
    public class UserConnection
    {
        public List<User> users = new UserList().GetUsers();
        private static UserConnection _instance;
        private static object _lock = new object();
        private UserConnection() { }

        public static UserConnection GetInstance()
        {
            lock(_lock)
            {
                if(_instance == null)
                {
                    _instance = new UserConnection();
                }

                return _instance;
            }
        }

        public bool ConnectUser()
        {
            foreach(var user in users)
            {
                if(user.username == "victor" && user.password == "victor")
                {
                    return true;
                }
            }

            return false;
        }

    }
}
