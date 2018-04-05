using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DZ2_15_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            int[] numbers = new int[12];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = gen.Next(163,190);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
        }
    }
}
