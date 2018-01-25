using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            int nomber = 0;
            Console.WriteLine("квадраты не превосходящие " + n);
            while (true)
            {
                nomber = nomber + 1;
                int quadrare = nomber * nomber;
                if (quadrare > n)
                {
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine(quadrare);
            }
        }
    }
}
