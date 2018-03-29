using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DZ_15_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 10, 35, 49, 30, 6, 0 };
            int remainder;
            for (int i = 0; i < numbers.Length; i++)
            {
                remainder = numbers[i] % 10;
                if (0 == remainder)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
