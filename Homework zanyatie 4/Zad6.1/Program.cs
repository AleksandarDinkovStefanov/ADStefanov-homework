using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма която пресмята с колко 0ли завършва факториелът на дадено число.



            int n = int.Parse(Console.ReadLine());
            int factorial = 1;
            int counter = 1;

            while (counter <= n)
            {
                factorial *= counter; // factorial = factorial * counter;
                counter++;
            }
            Console.WriteLine("{0}! = {1}", n, factorial);







            //while (factorial % 10 == 0 && factorial > 0)
            //{
            //    counter2++;

            //}
            //Console.WriteLine(counter);
            
            // дели факториел на 10 докато, факториел се дели на 10 без остатък 
            // и изкарай броя на делянията без остатък


            //while (factorial % 10 == 0 && factorial > 0)
            //{
            //    factorial %= 10;
            //    counter2 = counter2 + 1;
            //}
            //Console.WriteLine(counter2);

            //int factorial = 100;
            //int counter2 = 0;
            //if (factorial % 10 == 0 && factorial > 0)
            //{
            //  factorial = factorial % 10;
            //  counter2=counter2 +1;  
            //}
            //Console.WriteLine(counter2);
        }
    }
}
