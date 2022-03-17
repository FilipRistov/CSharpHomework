using System;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number:");
            string fNum = Console.ReadLine();
            Console.WriteLine("Enter the Second number:");
            string sNum = Console.ReadLine();
            Console.WriteLine("Enter the Third number:");
            string tNum = Console.ReadLine();
            Console.WriteLine("Enter the Fourth number:");
            string fourthNum = Console.ReadLine();
            bool fParse = int.TryParse(fNum, out int firstNumber);
            bool sParse = int.TryParse(sNum, out int secondNumber);
            bool tParse = int.TryParse(tNum, out int thirdNumber);
            bool fourthParse = int.TryParse(fourthNum, out int fourthNumber);
            int result = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
            if (!fParse || !sParse || !tParse || !fourthParse)
            {
                Console.WriteLine("Error, one of the numbers is invalid");
            }
            else if (firstNumber == 0 && secondNumber == 0 && thirdNumber == 0 && fourthNumber == 0)
            {
                Console.WriteLine("Error! Cannot calculate average of 0");
            }
            else
            {
                Console.WriteLine($"The average of {firstNumber}, {secondNumber}, {thirdNumber} and {fourthNumber} is: {result}");
            }           
        }
    }
}
