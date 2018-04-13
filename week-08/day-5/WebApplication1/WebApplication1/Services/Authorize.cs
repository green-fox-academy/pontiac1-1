using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class Authorize : IAuthorize
    {
        MyContext db;

        public Authorize(MyContext db)
        {
            this.db = db;
        }

        public string Login(string name, string pass)
        {
            User toLogin = db.Users.FirstOrDefault(u => u.Name == name);
            if (toLogin.Pass == pass)
            {
                return "home/index";
            }
            else
            {
                return "login";
            }
        }

        public string Logout()
        {
            return "login";
        }

        public string Reg()
        {
            using (db)
            {
                db.Users.Add();
                db.SaveChanges();
            }
        }
    }
}
