using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sem_7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ты у входа в пещеру, которую охраняет огр. У тебя есть варианты действий:");

            Console.WriteLine("1 Вступить в бой");
            Console.WriteLine("2 Ты отступаешь ");
            Console.WriteLine("3 Подкупаешь огра");
            Console.WriteLine("4 Ищешь обходной путь");

            int action = int.Parse(Console.ReadLine());

            switch(action){
                case 1:
                    Console.WriteLine("ты погибаешь, так как огр сильнее");
                    break;
                    case 1:
                    Console.WriteLine("");
                    break;

                    case 2:
                    Console.WriteLine("");
                    break;

                    case 3:
                    Console.WriteLine("");
                    break; 

                    case 4:
                    Console.WriteLine("т");
                    break;
                    // НЕ ДОДЕЛАНО! СДЕЛАТЬ ДОМА
        }
    }
}
