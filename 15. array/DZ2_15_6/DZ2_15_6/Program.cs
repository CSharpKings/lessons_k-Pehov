using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DZ2_15_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int[] numbers = new int[17];
            for (int i = 60; i >= 12; i = i - 3)
            {
                numbers[n] = i;
                n = n + 1;
            }
            for (int n2 = 0; n2 < numbers.Length; n2++)
            {
                Console.WriteLine(numbers[n2]);
            }

                Console.ReadLine();
        }
    }
}
