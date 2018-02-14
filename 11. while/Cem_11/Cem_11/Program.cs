using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Cem_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 0;
            while (time < 11) 
            {

                Thread.Sleep(1000);
                time = time + 1;
                Console.WriteLine(time);
            }
        }
    }
}
