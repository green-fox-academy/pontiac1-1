using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public int Score { get; set; }
        public DateTime Timestamp { get; set; }
        public User Owner { get; set; }
        public int Vote { get; set; }
        public List<User> Voters { get; set; }
    }
}
