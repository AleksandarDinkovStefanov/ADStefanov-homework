using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine(a1 + " е най-малкото число");
            }
            else if (a2 < a1 && a2 < a3 && a2 < a4 && a2 < a5)
            {
                Console.WriteLine(a2 + " е най-малкото число");
            }
            else if (a3 < a1 && a3 < a2 && a3 < a4 && a3 < a5)
            {
                Console.WriteLine(a3 + " е най-малкото число");
            }
            else if (a4 < a1 && a4 < a2 && a4 < a3 && a4 < a5)
            {
                Console.WriteLine(a4 + " е най-малкото число");
            }
            else if (a5 < a1 && a5 < a2 && a5 < a3 && a5 < a4)
            {
                Console.WriteLine(a5 + " е най-малкото число");
            }
            
            
            //else if (a1 > a2 && a1 > a3 && a1 > a4 && a1 > a5)
            //{
            //    Console.WriteLine(a1 + " е най-голямото число");
            //}
            //else if (a2 > a1 && a2 > a3 && a2 > a4 && a2 > a5)
            //{
            //    Console.WriteLine(a2 + " е най-голямото число");
            //}
            //else if (a3 > a1 && a3 > a2 && a3 > a4 && a3 > a5)
            //{
            //    Console.WriteLine(a3 + " е най-голямото число");
            //}
            //else if (a4 > a1 && a4 > a2 && a4 > a3 && a4 > a5)
            //{
            //    Console.WriteLine(a4 + " е най-голямото число");
            //}
            //else if (a5 > a1 && a5 > a2 && a5 > a3 && a5 > a4)
            //{
            //    Console.WriteLine(a5 + " е най-голямото число");
            //}
           
        }
    }
}
