using System;

namespace TaskThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the First Number:");
            string fNum = Console.ReadLine();
            Console.WriteLine("Input the Second Number:");
            string sNum = Console.ReadLine();
            bool fParse = int.TryParse(fNum, out int firstNumber);
            bool sParse = int.TryParse(sNum, out int secondNumber);
            if(!fParse || !sParse)
            {
                Console.WriteLine("One of the numbers is invalid");
            }
            else
            {
                Console.WriteLine("After Swapping:");
                Console.WriteLine("First Number: " + secondNumber);
                Console.WriteLine("Second Number: " + firstNumber);
            }
        }
    }
}
