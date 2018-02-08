using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace cem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите грузоподъемность НЛО");
            int maxMass = int.Parse(Console.ReadLine());
            int sum = 0;
            int cowSum = 0;
            while (true)
            {
                Console.WriteLine("Введите вес коровы");
                int cowMass = int.Parse(Console.ReadLine());
                sum = sum + cowMass;
                cowSum = cowSum + 1;
                if (sum > maxMass)
                {
                    Console.WriteLine("В отсеке " + cowSum + " коров(ы)");

                    Console.WriteLine("Отсек для коров заполнен, взлетаем!");
                    Thread.Sleep(3000);
                    break;
                }
            }
        }
    }
}
