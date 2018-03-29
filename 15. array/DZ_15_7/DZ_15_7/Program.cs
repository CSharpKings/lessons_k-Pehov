using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DZ_15_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numbers = {5.5, 3.33, 11.6, 8.3, 17.1, 6.9, 81 };   
            for (int i = 0;i < numbers.Length; i++)
            {
                if (numbers[i] > 10)
                {
                    numbers[i] = Math.Sqrt(numbers[i]);
                }
            }
            for (int n = 0; n < numbers.Length; n++)
            {
                Console.WriteLine(numbers[n]);
            }

            Console.ReadLine();
        }
    }
}
