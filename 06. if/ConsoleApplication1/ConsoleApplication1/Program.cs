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
            Console.WriteLine("возраст дракона");
            int are = int.Parse(Console.ReadLine());
        
            Console.WriteLine("здоровье дракона");
            int hp = int.Parse(Console.ReadLine());

            if (are < 150)
            {
                Console.WriteLine("Бейся");
            }
            if (are > 150)
            {
                Console.WriteLine("уходи");
            }
            if (hp < 50)
            {
                Console.WriteLine("Бейся");
            }
            if (hp < 50)
            {
                Console.WriteLine("уходи");
            }
            Console.ReadLine();
            


        }
    }
}
