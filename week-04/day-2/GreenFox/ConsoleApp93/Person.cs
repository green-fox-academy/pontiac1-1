using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp93
{
    public class Person
    {
        public string name;
        protected int age;
        protected string gender;

        public Person(string name = "Jane Doe", int age = 30, string gender = "female")
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public virtual void Introduce()
        {
            Console.WriteLine("Hi i am {0}, i am {1} years old, and i am a {2}", name, age, gender); 
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My life goal is: to live for the moment");
        }
    }
}
