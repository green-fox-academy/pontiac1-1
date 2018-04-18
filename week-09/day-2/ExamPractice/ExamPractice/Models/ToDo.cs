using System;
using System.Collections.Generic;

namespace ExamPractice.Models
{
    public partial class ToDo
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool Priority { get; set; }
    }
}
