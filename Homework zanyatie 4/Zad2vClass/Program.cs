using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2vClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число");
            var a = int.Parse(Console.ReadLine());

            do
            {
                int a = a --;
            } while (a > 0);
        }
    }
}
