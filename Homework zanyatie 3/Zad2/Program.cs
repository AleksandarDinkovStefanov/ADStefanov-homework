using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която изчислява бонус точки на база
            // резултат от игра. Потребителят трябва да въведе своите точки в
            // интервалa[1;9]. Ако точките са в интервала [1;3], умножете ги по
            // 5. Ако точките са в интервала [4;6], умножете ги по 10. Ако
            // точките са в интервала [7;9], умножете ги по 50. Резултатът
            // изведете на екрана.

            Console.WriteLine("Entrer number of bonus points (1-9)");
            int a = int.Parse(Console.ReadLine());

            if (a >= 1 && a <=3)
            {
                Console.WriteLine(a * 5);
            }
            else if (a >= 4 && a <=6)
            {
                Console.WriteLine(a * 10);
            }
            else if (a >= 7 && a <= 9)
            {
                Console.WriteLine(a * 50);
            }
            else
            {
                Console.WriteLine("Wrong input, reload the program");
            }
        }
    }
}
