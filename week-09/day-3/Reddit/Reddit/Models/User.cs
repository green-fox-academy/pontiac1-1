using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Post> MyPosts { get; set; }
    }
}
