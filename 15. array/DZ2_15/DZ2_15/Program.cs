using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DZ2_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, -5, 3, 5, -19, -15, 7, 8};
            for (int i = 1; i < numbers.Length - 1; i++) 
            {
                if (numbers[i] < 0 && numbers[i + 1] < 0 || numbers[i] > 0 && numbers[i + 1] > 0)
                {
                        Console.WriteLine(numbers[i] + " " + numbers[i+1]);
                        break;
                }
            }
            Console.ReadLine();

        }
    }
}
