using System;
using System.Collections.Generic;
using System.Text;

namespace TaskOne
{
    class Student
    {
        public string Name { get; set; }
        public Subjects Subject { get; set; }
        public List<int> Grades { get; set; }
        public Student(string name, Subjects subject, List<int> grades)
        {
            Name = name;
            Subject = subject;
            Grades = grades;
        }
    }
}
