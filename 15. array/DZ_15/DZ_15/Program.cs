using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DZ_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 3, 23, 15, 10, 5, 36 };
            int remainder;
            for (int i = 0; i < numbers.Length; i++)
            {
                remainder = numbers[i] % 2;
                if (0 == remainder)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
