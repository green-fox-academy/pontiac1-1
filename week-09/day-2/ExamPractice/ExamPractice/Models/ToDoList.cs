using System;
using System.Collections.Generic;

namespace ExamPractice.Models
{
    public partial class ToDoList
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool Done { get; set; }
        public bool Important { get; set; }
        public bool Urgent { get; set; }
    }
}
