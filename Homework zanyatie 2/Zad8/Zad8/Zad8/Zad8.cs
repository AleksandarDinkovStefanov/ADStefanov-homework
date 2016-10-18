using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad8
{
    class Zad8
    {
        static void Main(string[] args)
        {
            // Задача 8: Напишете програма, която приема стринг от конзолата, и
            // извежда N-тия символ от стринга, като резултат. 
            // Забележка: За да има решение задачата въведения стринг трябва да има минимум N+1 символа.

            Console.WriteLine("Въведете текст");
            string str = Console.ReadLine();
            Console.WriteLine("Петият символ е " + str[5]);
        }
    }
}
