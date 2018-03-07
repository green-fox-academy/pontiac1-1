using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp93
{
    class Sponsor : Person
    {
        public string company;
        public int studentsHired;

        public Sponsor()
        {
            company = "Google";
            studentsHired = 0;
        }
        public Sponsor(string name, int age, string gender, string company)
            :base(name, age, gender)
        {
            this.company = company;
            studentsHired = 0;
        }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine("I am representing {0} and i have hired {1} student so far.", company, studentsHired);
        }

        public void Hire()
        {
            studentsHired++;
        }
    }
}
