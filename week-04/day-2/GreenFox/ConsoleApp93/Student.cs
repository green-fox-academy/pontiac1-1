using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp93
{
    public class Student : Person
    {
        protected string prevOrg;
        protected int skippedDays;

        public Student()
        {
            prevOrg = "School of Life";
            skippedDays = 0;
        }

        public Student(string name, int age, string gender, string prevOrg = "The School of Life", int skippedDay = 0) : base(name, age, gender)
        {
            this.prevOrg = prevOrg;
            this.skippedDays = skippedDay;
        }

        public void SkipDays(int a)
        {
            skippedDays += a;
        }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine(" My previous organization is {0}, and i have skipped {1} days", prevOrg, skippedDays);
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is to be a junior programmer.");
        }
    }
}
