using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number:");
            string fNum = Console.ReadLine();
            Console.WriteLine("Enter the Second number:");
            string sNum = Console.ReadLine();
            Console.WriteLine("Enter the Operation");
            string operation = Console.ReadLine();
            bool parseOne = double.TryParse(fNum, out double firstNumber);
            bool parseTwo = double.TryParse(sNum, out double secondNumber);
            if (!parseOne || !parseTwo)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                switch (operation)
                {
                    case "+":
                        {
                            Console.WriteLine(firstNumber + secondNumber);
                        }
                        break;
                    case "-":
                        {
                            Console.WriteLine(firstNumber - secondNumber);
                        }
                        break;
                    case "/":
                        {
                            Console.WriteLine(firstNumber / secondNumber);
                        }
                        break;
                    case "*":
                        {
                            Console.WriteLine(firstNumber * secondNumber);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine($"Error! Invalid operator {operation}");
                        }
                        break;
                }
            }
        }
    }
}
