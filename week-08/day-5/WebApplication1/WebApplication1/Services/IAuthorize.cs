using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    interface IAuthorize
    {
        string Reg();
        string Login(string name, string pass);
        string Logout();
    }
}
