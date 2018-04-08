using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MManager.Models;
using System.IO;
using System.Xml.Serialization;

namespace MManager.Services
{
    public class Auth : IAuth
    {
        public User CurrentUser { get; set; }

        public string Register(string user, string pass, string repass)
        {
            if (pass == repass)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(User));
                using (TextWriter tw = new StreamWriter(@"UserLog\" + user + ".xml"))
                {
                    serializer.Serialize(tw, new User { Name = user, Pass = pass });
                }

                return "SignIn";
            }
            else
            {
                return "SignUp";
            }
        }

        public string Authenticate(string user, string pass)
        {
            //try
            //{
                XmlSerializer deserializer = new XmlSerializer(typeof(User));
                TextReader tr = new StreamReader(@"UserLog\" + user + ".xml");
                object obj = deserializer.Deserialize(tr);
                CurrentUser = (User)obj;
            tr.Close();
                if (CurrentUser.Pass == pass)
                {
                    File.Delete(@"UserLog\" + user + ".xml");
                    return "../Profile/Index";
                }
                else
                {
                    return "SignIn";
                }
            //}
            //catch (Exception)
            //{

            //    return "SignUp";
            //}
        }

        public void LogOut()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(User));
            using (TextWriter tw = new StreamWriter(@"UserLog\" + CurrentUser.Name + ".xml"))
            {
                serializer.Serialize(tw, new User { Name = CurrentUser.Name, Pass = CurrentUser.Pass });
            }

            CurrentUser = null;
        }
    }
}
