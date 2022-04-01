using System;
using System.Collections.Generic;
using System.Linq;
using TaskOne.Model;

namespace TaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Admin adminOne = new Admin("Main");
                Admin adminTwo = new Admin("Support");
                List<Admin> admins = new List<Admin>() { adminOne, adminTwo };

                Teacher teacherOne = new Teacher("Maria", Subjects.History);
                Teacher teacherTwo = new Teacher("Klara", Subjects.History);
                List<Teacher> teachers = new List<Teacher>() { teacherOne, teacherTwo };

                Student studentOne = new Student("John", Subjects.History, new List<int>() { 7, 10, 8, 6, 5 });
                Student studentTwo = new Student("Malcom", Subjects.History, new List<int>() { 7, 10, 5, 7, 9 });
                Student studentThree = new Student("Chris", Subjects.Art, new List<int>() { 7, 7, 5, 5, 10 });
                Student studentFour = new Student("Johnny", Subjects.Art, new List<int>() { 5, 7, 8, 10, 8 });
                Student studentFive = new Student("Peter", Subjects.Music, new List<int>() { 9, 10, 9, 10, 5 });
                Student studentSix = new Student("Stark", Subjects.Music, new List<int>() { 9, 6, 8, 8, 7 });
                Student studentSeven = new Student("Mike", Subjects.Physics, new List<int>() { 10, 10, 8, 5, 7 });
                Student studentEight = new Student("Adam", Subjects.Physics, new List<int>() { 5, 10, 10, 10, 10 });
                Student studentNine = new Student("Bruce", Subjects.Math, new List<int>() { 7, 8, 8, 7, 6 });
                Student studentTen = new Student("Timmy", Subjects.Math, new List<int>() { 5, 10, 6, 8, 7 });
                List<Student> students = new List<Student>() { studentOne, studentTwo,studentThree,studentFour,studentFive,
                studentSix,studentSeven,studentEight, studentNine, studentTen };

                Console.WriteLine("Log In As:");
                Console.WriteLine("Admin");
                Console.WriteLine("Trainer");
                Console.WriteLine("Student");
                string input = Console.ReadLine();
                if (input.ToLower() == "admin")
                {
                    Console.WriteLine("Add Or Remove:");
                    string addRemove = Console.ReadLine();
                    Console.WriteLine("Teacher");
                    Console.WriteLine("Student");
                    Console.WriteLine("Admin");
                    string selected = Console.ReadLine();

                    switch (selected.ToLower())
                    {
                        case "teacher":
                            if (addRemove.ToLower() == "add")
                            {
                                Console.WriteLine("Enter name for the teacher");
                                string teacherName = Console.ReadLine();
                                Console.WriteLine("Enter teacher's subject(Math/Physics/Art/Music/History)");
                                string teacherSubject = Console.ReadLine();
                                List<Teacher> addedTeacher = Teacher.AddTeacher(teacherName, (Subjects)Enum.Parse(typeof(Subjects), teacherSubject));
                                teachers.AddRange(addedTeacher);
                                Console.WriteLine(addedTeacher[0].Name + " Succesfully added");
                            }
                            else if (addRemove.ToLower() == "remove")
                            {
                                Console.WriteLine("Select the teacher you want to remove");
                                teachers.ForEach(m => Console.WriteLine(m.Name));
                                string teacherRemove = Console.ReadLine();
                                teachers.Remove(teachers.Single(m => m.Name.ToLower() == teacherRemove.ToLower()));
                                Console.WriteLine(teacherRemove + " Succesfully removed");
                            }
                            break;
                        case "student":
                            if (addRemove.ToLower() == "add")
                            {
                                Console.WriteLine("Enter name for the student");
                                string studentName = Console.ReadLine();
                                Console.WriteLine("Enter Subject for the student(Math/Physics/Art/Music/History)");
                                string enteredSubject = Console.ReadLine();
                                Console.WriteLine("Enter five grades for the student");
                                bool eOne = int.TryParse(Console.ReadLine(), out int gOne);
                                bool eTwo = int.TryParse(Console.ReadLine(), out int gTwo);
                                bool eThree = int.TryParse(Console.ReadLine(), out int gThree);
                                bool eFour = int.TryParse(Console.ReadLine(), out int gFour);
                                bool eFive = int.TryParse(Console.ReadLine(), out int gFive);
                                Student addedStudent = Add(studentName, (Subjects)Enum.Parse(typeof(Subjects), enteredSubject),
                                    new List<int>() { gOne, gTwo, gThree, gFour, gFive });
                                List<Student> newStudent = new List<Student>() { addedStudent };
                                students.AddRange(newStudent);
                                Console.WriteLine(addedStudent.Name + " Succesfully added");
                            }
                            else if (addRemove.ToLower() == "remove")
                            {
                                Console.WriteLine("Select the student you want to remove");
                                students.ForEach(m => Console.WriteLine(m.Name));
                                string studentRemove = Console.ReadLine();
                                var remove = students.Single(m => m.Name.ToLower() == studentRemove.ToLower());
                                students.Remove(remove);
                                Console.WriteLine(remove.Name + " Succesfully removed");
                            }
                            break;
                        case "admin":
                            if (addRemove.ToLower() == "add")
                            {
                                Console.WriteLine("Enter User Name");
                                string userName = Console.ReadLine();
                                List<Admin> addedAdmin = AddAdmin(userName);
                                admins.AddRange(addedAdmin);
                                Console.WriteLine(addedAdmin[0].UserName + " Succesfully added");
                            }
                            else if (addRemove.ToLower() == "remove")
                            {
                                Console.WriteLine("Select which admin you want to remove");
                                foreach (Admin admin in admins.Where(m => m.UserName != "Main"))
                                    Console.WriteLine(admin.UserName);
                                string adminToRemove = Console.ReadLine();                         
                                Admin removeAdmin = admins.First(m => m.UserName.ToLower() == adminToRemove.ToLower());
                                admins.Remove(removeAdmin);
                                Console.WriteLine(removeAdmin.UserName + " Succesfully removed");
                            }
                            break;
                        default:
                            {
                                throw new Exception("Incorrect Input");
                            }
                            break;
                    }
                }

                if (input.ToLower() == "trainer")
                {
                    Console.WriteLine("Choose:");
                    Console.WriteLine("1. See all students");
                    Console.WriteLine("2. See all subjects");
                    string trainerInput = Console.ReadLine();

                    switch (trainerInput)
                    {
                        case "1":
                            foreach (Student student in students)
                            {
                                Console.WriteLine(student.Name);
                            }
                            Console.WriteLine("Do you want to choose a student(Y/N)");
                            string answer = Console.ReadLine();
                            if (answer.ToLower() == "y")
                            {
                                Console.WriteLine("Choose name");
                                string studentName = Console.ReadLine();
                                foreach (Student student in students)
                                {
                                    if (studentName.ToLower() == student.Name.ToLower())
                                    {
                                        Console.WriteLine($"{student.Name} is learning {student.Subject}");
                                    }
                                    else if(studentName.ToLower() != student.Name.ToLower())
                                    {
                                        throw new ArgumentException("Invalid Student Name");
                                    }
                                }
                            }
                            break;
                        case "2":
                            Console.WriteLine($"{Subjects.Art} is attended by {students.Where(m => m.Subject == Subjects.Art).Count()} students");
                            Console.WriteLine($"{Subjects.Physics} is attended by {students.Where(m => m.Subject == Subjects.Physics).Count()} students");
                            Console.WriteLine($"{Subjects.Music} is attended by {students.Where(m => m.Subject == Subjects.Music).Count()} students");
                            Console.WriteLine($"{Subjects.History} is attended by {students.Where(m => m.Subject == Subjects.History).Count()} students");
                            Console.WriteLine($"{Subjects.Math} is attended by {students.Where(m => m.Subject == Subjects.Math).Count()} students");
                            break;
                        default:
                            throw new Exception("Error");
                            break;
                    }
                }
                if (input.ToLower() == "student")
                {
                    foreach (Student student in students)
                    {
                        Console.WriteLine($"Name: {student.Name} Subject: {student.Subject} Grades: {string.Join(", ", student.Grades)}");
                    }
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static Student Add(string name, Subjects subj, List<int> grade)
        {
            return new Student(name, subj, grade);
        }
        public static List<Admin> AddAdmin(string name)
        {
            var newAdmin = new Admin(name);
            return new List<Admin>() { newAdmin };
        }
    }
}
