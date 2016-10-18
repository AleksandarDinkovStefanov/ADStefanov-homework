using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число n, чийто факториел да се изчисли: ");
            int n = int.Parse(Console.ReadLine());
            double factorial = 1;
            int counter = 1;

            while (counter <= n)
            {
                factorial *= counter; // factorial = factorial * counter;
                counter++;
            }
            Console.WriteLine("{0}! = {1}", n, factorial);

            int counter2 = 0;


            while (factorial % 10 == 0)
            {
                factorial = factorial / 10; 
                counter2++;
            }
            Console.WriteLine("Броят на нулите е "  + counter2);
        }
    }
}
