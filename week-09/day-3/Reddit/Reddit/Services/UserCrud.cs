using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reddit.Entities;
using Reddit.Models;

namespace Reddit.Services
{
    public class UserCrud : ICrud<User>
    {
        RedditContext db;

        public UserCrud(RedditContext db)
        {
            this.db = db;
        }

        public User Create(User TtoCreate)
        {
            db.UserList.Add(TtoCreate);
            db.SaveChanges();
            return TtoCreate;
        }

        public string Delete(string name)
        {
            db.UserList.Remove(db.UserList.FirstOrDefault(u => u.Name == name));
            db.SaveChanges();
            return $"{name} successfully deleted!";
        }

        public List<User> Read()
        {
            return db.UserList.ToList();
        }

        public void Update(User TtoUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
