using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reddit.Models;
using Reddit.Entities;

namespace Reddit.Services
{
    public class Auth : IAuth
    {
        RedditContext db;
        User currentUser;

        public Auth(RedditContext db, User currentUser)
        {
            this.db = db;
            this.currentUser = currentUser;
        }

        public string Login(string name)
        {
            try
            {
                currentUser = db.UserList.FirstOrDefault(u => u.Name == name);
                return $"welcome {currentUser.Name}!";
            }
            catch (Exception)
            {

                return $"no such user";
            }
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}

