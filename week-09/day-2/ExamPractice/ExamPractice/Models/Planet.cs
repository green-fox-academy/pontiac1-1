using System;
using System.Collections.Generic;

namespace ExamPractice.Models
{
    public partial class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Population { get; set; }
        public Spaceship Dock { get; set; }
    }
}
