using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cem_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово.");
            string str = Console.ReadLine();
            int strlight = str.Length;
            for (int i = 0; i < str.Length; i++)
            {
                int contrarilyI = 0;
                contrarilyI = str.Length - i - 1;
                Console.WriteLine(str[contrarilyI]);
            }
            Console.ReadLine();
        }
    }
}
