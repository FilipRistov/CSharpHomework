using System;
using System.Collections.Generic;

namespace TaskOne
{
    class Program
    {
        static void Main(string[] args)      
        {
            Queue<int> numbers = new Queue<int>();
            do
            {
                Console.WriteLine("Enter Number:");
                int.TryParse(Console.ReadLine(), out int num);
                numbers.Enqueue(num);
                Console.WriteLine("Enter Y/N");

            }
            while(Console.ReadLine().ToLower() == "y");
            Console.WriteLine(numbers.Count);
        }
    }
}
