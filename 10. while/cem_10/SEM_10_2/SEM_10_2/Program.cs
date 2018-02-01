using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEM_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Введите число");
                int nomber = int.Parse(Console.ReadLine());
                sum = nomber + sum;
                Console.WriteLine(sum);
                if (sum > 100)
                {
                    break;
                }
            }
        }
    }
}
