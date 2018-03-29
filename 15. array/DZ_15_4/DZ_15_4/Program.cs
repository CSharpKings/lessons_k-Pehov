using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DZ_15_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Человек", "пень", "кот", "утка" };
            string[] words2 = { "быстро", "редко", "прекрасно"  };
            string[] words3 = { "бегает", "горит", "готовит", "летит" };
            Random gen = new Random();
            int n1 = gen.Next(words.Length);
            int n2 = gen.Next(words2.Length);
            int n3 = gen.Next(words3.Length);
            Console.WriteLine(words[n1]+ " "+ words2[n2]+ " " + words3[n3] + ".");
            Console.ReadLine();
        }
    }
}
