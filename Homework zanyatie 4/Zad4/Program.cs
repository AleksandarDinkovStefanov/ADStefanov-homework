using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Направете програма, която извежда на конзолата всички числа от 1 до 100, 
            // които се делят или на 7, или на 11, без остатък. Решете задачата по 3 
            // различни начина: с трите цикли от лекцията.
            
            // Вариант1 (while):
            var a = 1;
            while (a <= 100)
            {
                if (a % 7 == 0 || a % 11 == 0)
                {
                    Console.WriteLine(a);
                 }
                a++;

            // Вариант2 (do while):
            //var a = 0;
            //do
            //{
            //    a++;
            //    if (a % 7 == 0 || a % 11 == 0)
            //    {
            //        Console.WriteLine(a);
            //    }
            //}
            //while (a <= 100);

            // Вариант3 (for):
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 7 == 0 || i % 11 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            }
        }
    }
}


