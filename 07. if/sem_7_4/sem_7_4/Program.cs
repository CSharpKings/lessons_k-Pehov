using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sem_7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Шахматная ладья ходит по горизонтали или вертикали. Даны две различные клетки шахматной доски, определите, может ли ладья попасть с первой клетки на вторую одним ходом.

            // получает на вход четыре числа от 1 до 8 каждое, задающие номер столбца и номер строки сначала для первой клетки, потом для второй клетки.
            //Программа должна вывести YES, если из первой клетки ходом ладьи можно попасть во вторую или NO в противном случае.
            Console.WriteLine("первая товка X");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("первая товка Y");
            int Y = int.Parse(Console.ReadLine());

            Console.WriteLine("вторая товка X");
            int X2 = int.Parse(Console.ReadLine());

            Console.WriteLine("вторая товка Y");
            int Y2 = int.Parse(Console.ReadLine());

            if (X == X2 || Y == Y2)
            {
                Console.WriteLine("можно");
            }
            else
            {
                Console.WriteLine("нельзя");
            }
            Console.ReadLine();
        }
    }
}
