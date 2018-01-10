using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnitude {
class Program {
static void Main(string[] args) {
int num;
Console.WriteLine("Введите число:");
num = int.Parse(Console.ReadLine());
Console.WriteLine("Число: " + num);

Console.WriteLine("Длина числа: " + GetMagnitude(num));
Console.Read();
}

static int GetMagnitude(int number) {
int mag = 0;
while (number > 0) {
mag++;
number = number / 10;
}

return mag;
}
}
}
