using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cem_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int seven = 7;
            int proizvedenie = 0;
            for (int number = 1; number <= 9; number++)
            {
                proizvedenie = number * seven;
                Console.WriteLine(number + " * " + seven + " = " + proizvedenie);
            }
            Console.ReadLine();
        }
    }
}
