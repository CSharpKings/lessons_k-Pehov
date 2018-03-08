using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sem_14_masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 6, 5, 2, 5};
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] == 5)
                {
                    Console.WriteLine("номер '5' "+ i);
                    break;
                }
                
            }
            Console.ReadLine();
        }
    }
}
