using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class LogDTO
    {
        public int ID { get; set; }
        public DateTime createdAt { get; set; }
        public string Endpoint {get;set;}
        public string Data { get; set; }
    }
}
