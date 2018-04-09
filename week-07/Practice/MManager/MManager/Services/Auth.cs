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
        public Account CurrentAccount { get; set; }

        public string Register(string user, string pass, string repass, double balance, double id)
        {
            if (pass == repass)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Account));
                using (TextWriter tw = new StreamWriter(@"AccountLog\" + user + ".xml"))
                {
                    serializer.Serialize(tw, new Account { Name = user, Pass = pass, Balance = balance});
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
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Account));
                TextReader tr = new StreamReader(@"AccountLog\" + user + ".xml");
                object obj = deserializer.Deserialize(tr);
                CurrentAccount = (Account)obj;
                tr.Close();
                if (CurrentAccount.Pass == pass)
                {
                    File.Delete(@"AccountLog\" + user + ".xml");
                    return "../Profile/Index";
                }
                else
                {
                    return "SignIn";
                }
            }
            catch (Exception)
            {

                return "SignUp";
            }
        }

        public void LogOut()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Account));
            using (TextWriter tw = new StreamWriter(@"AccountLog\" + CurrentAccount.Name + ".xml"))
            {
                serializer.Serialize(tw, new Account { Name = CurrentAccount.Name, Pass = CurrentAccount.Pass, Balance = CurrentAccount.Balance, ID = CurrentAccount.ID });
            }

            CurrentAccount = null;
        }

        public void ConnectAccount(long id)
        {
            CurrentAccount.ID = id;
        }
    }
}
