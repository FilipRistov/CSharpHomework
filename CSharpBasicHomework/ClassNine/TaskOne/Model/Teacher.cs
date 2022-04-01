using System;
using System.Collections.Generic;
using System.Text;

namespace TaskOne.Model
{
    class Teacher
    {
        public string Name { get; set; }
        public Subjects Subject { get; set; }
        public Teacher(string name, Subjects subject)
        {
            Name = name;
            Subject = subject;
        }
        public static List<Teacher> AddTeacher(string name, Subjects subj)
        {
            var newAdmin = new Teacher(name, subj);
            return new List<Teacher>() { newAdmin };
        }
    }
}
