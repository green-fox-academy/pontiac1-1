using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Pass { get; set; }
        public List<User> Friends { get; set; }
        public List<Post> Posts { get; set; }
    }
}
