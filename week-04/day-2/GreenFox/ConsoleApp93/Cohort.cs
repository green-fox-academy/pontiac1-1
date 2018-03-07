using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp93
{
    public class Cohort
    {
        public string name;
        public List<Student> students;
        public List<Mentor> mentors;

        public Cohort(string name)
        {
            this.name = name;
            students = new List<Student>();
            mentors = new List<Mentor>();

        }

        public void AddStudent(Student a)
        {
            students.Add(a);
        }

        public void AddMentor(Mentor a)
        {
            mentors.Add(a);
        }

        public void Info()
        {
            Console.WriteLine("Cohort name: {0}. Number of students: {1}. Number of mentors: {2}"
                , name, students.Count, mentors.Count);
        }

    }
}
