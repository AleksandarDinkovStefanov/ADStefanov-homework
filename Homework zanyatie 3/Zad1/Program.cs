using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която взема дадена цифра (0-9) и я изписва с
            // дума (на англ. език)

            Console.WriteLine("Please enter integer from 0 to 9");
            int a = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (a == 1)
            {
                Console.WriteLine("one");
            }
            else if (a == 2)
            {
                Console.WriteLine("two");
            }
            else if (a == 3)
            {
                Console.WriteLine("three");
            }
            else if (a == 4)
            {
                Console.WriteLine("four");
            }
            else if (a == 5)
            {
                Console.WriteLine("five");
            }
            else if (a == 6)
            {
                Console.WriteLine("six");
            }
            else if (a == 7)
            {
                Console.WriteLine("seven");
            }
            else if (a == 8)
            {
                Console.WriteLine("eight");
            }
            else if (a == 9)
            {
                Console.WriteLine("nine");
            }
            else
            {
                Console.WriteLine("wrong input");
            }
        }
    }
}
