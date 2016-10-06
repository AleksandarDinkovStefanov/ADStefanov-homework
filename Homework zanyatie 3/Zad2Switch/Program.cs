using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2Switch
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

            switch (a)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(a * 5);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(a * 10);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(a * 50);
                    break;
                default:
                    Console.WriteLine("Wrong imput");
                    Console.WriteLine("Entrer number of bonus points (1-9)");
                    break;
            }
        }
    }
}
