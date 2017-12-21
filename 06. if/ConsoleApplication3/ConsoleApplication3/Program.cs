using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("рост");
            int rost = int.Parse(Console.ReadLine());
            
            Console.WriteLine("твой вес");
            int ves = int.Parse(Console.ReadLine());
            
            if (rost - 100 == ves) {
                Console.WriteLine("норма");
            }
            if (rost - 100 < ves) {
                Console.WriteLine("толстей");
            }
            if (rost - 100 > ves) {
                Console.WriteLine("худей");
            }
            Console.ReadLine();
        }
    }
}
