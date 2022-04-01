using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birth = new DateTime(2001, 02, 23);
            AgeCalculator(birth);
        }
        public static void AgeCalculator(DateTime date)
        {
            DateTime now = DateTime.Now;
            int diff = ((now.Date - date.Date).Days);
            int age = diff / 365;
            Console.WriteLine(age);
        }
    }
}
