using System;
using System.Collections.Generic;

namespace ExamPractice.Models
{
    public partial class LogList
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string Endpoint { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
