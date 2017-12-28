using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sem_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ввести возраст дракона");
            int are = int.Parse(Console.ReadLine());
            Console.WriteLine("ввести здоровье дракона");
            int hp = int.Parse(Console.ReadLine());

            if (are < 150 || hp < 50)
            {
                Console.WriteLine("бейся");
            }
            else
            {
                Console.WriteLine("Тiкай");
            }
            Console.ReadLine();
        }
    }
}
