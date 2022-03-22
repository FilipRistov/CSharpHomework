using System;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsGOne = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsGTwo = { "Zoki", "Mile", "Brus", "Petko", "Vele" };
            Console.WriteLine("Enter student group:(1 or 2)");
            string groupInput = Console.ReadLine();
            if (groupInput == "1")
            {
                Console.WriteLine("The Students in G1 are:");
                foreach (string element in studentsGOne)
                {
                    Console.WriteLine(element);
                }
            }
            else if (groupInput == "2")
            {
                Console.WriteLine("The Students in G2 are:");
                foreach (string element in studentsGTwo)
                {
                    Console.WriteLine(element);
                }
            }
            else
            {
                Console.WriteLine("Invalid student group number");
            }
        }
    }
}
