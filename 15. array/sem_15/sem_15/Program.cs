using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sem_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 14, 6, 9, 3, 19, 32, 20 };
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.ReadLine();

        }
    }
}
