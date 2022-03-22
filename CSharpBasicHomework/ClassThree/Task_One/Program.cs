using System;

namespace ClassThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter integer no.{i + 1}:");
                string number = Console.ReadLine();
                int.TryParse(number, out int parsed);
                array[i] = parsed;
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine($"The result is: {sum}");
        }
    }
}