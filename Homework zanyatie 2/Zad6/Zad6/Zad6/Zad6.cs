using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad6
    {
        static void Main(string[] args)
        {
            // Задача6: Напишете програма, която приема реално число като вход, и
            // изкарва на конзолата резултата от делението му с цяло число.

            Console.WriteLine("въведи реално число число");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("въведи цяло число");
            double b = double.Parse(Console.ReadLine());
            double c = a / b;
            Console.WriteLine(c);
        }
    }
}
