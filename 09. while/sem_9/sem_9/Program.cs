using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sem_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("введите число");
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
                Console.WriteLine(sum);
                

            }
        }
    }
}
