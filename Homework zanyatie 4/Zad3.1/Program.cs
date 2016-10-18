using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която чете от конзолата поредица от цели числа (примерно 5 числа) 
            // и отпечатва най-малкото и най-голямото от тях.

            Console.WriteLine("Въведете поредица от 5 цели числа");
            Console.WriteLine("Първо число");
            var a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Второ число");
            var a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Трето число");
            var a3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Четвърто число");
            var a4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Пето число");
            var a5 = int.Parse(Console.ReadLine());
            var min = a1;
            var max = a5;

            if (a1 < a2 && a1 < a3 && a1 < a4 && a1 < a5)
            {
                min = a1;
            }
            else if (a2 < a1 && a2 < a3 && a2 < a4 && a2 < a5)
            {
                min = a2;
            }
            else if (a3 < a1 && a3 < a2 && a3 < a4 && a3 < a5)
            {
                min = a3;
            }
            else if (a4 < a1 && a4 < a2 && a4 < a3 && a4 < a5)
            {
                min = a4;
            }
            else if (a5 < a1 && a5 < a2 && a5 < a3 && a5 < a4)
            {
                min = a5;
            }

            else if (a1 > a2 && a1 > a3 && a1 > a4 && a1 > a5)
            {
                max = a1;
            }
            else if (a2 > a1 && a2 > a3 && a2 > a4 && a2 > a5)
            {
                max = a2;
            }
            else if (a3 > a1 && a3 > a2 && a3 > a4 && a3 > a5)
            {
                max = a3;
            }
            else if (a4 > a1 && a4 > a2 && a4 > a3 && a4 > a5)
            {
                max = a4;
            }
            else if (a5 > a1 && a5 > a2 && a5 > a3 && a5 > a4)
            {
                max = a5;
            }

            Console.WriteLine("min value = {0}", min);
            Console.WriteLine("max value = {0}", max);
        }
    }
}
