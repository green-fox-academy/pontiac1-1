using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp93
{
    public class Mentor : Person
    {
        public string level;

        public Mentor()
        {
            level = "intermedate";
        }
        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine("My level is {0} programmer", level);
        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }
    }
}
