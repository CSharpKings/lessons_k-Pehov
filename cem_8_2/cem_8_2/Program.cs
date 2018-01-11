using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace cem_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 0;
            while (true)
            {
                Console.WriteLine("0" + time);
                Thread.Sleep(1000);
                time = time + 1;
            }
        }
    }
}
