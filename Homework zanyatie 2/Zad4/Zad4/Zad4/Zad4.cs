using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Zad4
    {
        static void Main(string[] args)
        {
            // Напишете проргама която приема 2 целочислени числа за вход и
            // извежда остатъка от делението на числата.
            
            //решение 1
            Console.WriteLine("въведи цяло число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("въведи второ цяло число");
            int b = int.Parse(Console.ReadLine());
            int c = a / b;
            int ostatak = a - (b * c);
            Console.WriteLine(ostatak);

            //решение 2
            //Console.WriteLine("въведи цяло число");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("въведи второ цяло число");
            //int b = int.Parse(Console.ReadLine());
            //int result = a % b;
            //Console.WriteLine(result);

            //решение 3 (евентуално)
            //Console.WriteLine("въведи цяло число");
            //float a = float.Parse(Console.ReadLine());
            //Console.WriteLine("въведи второ цяло число");
            //float b = float.Parse(Console.ReadLine());
            //float c = a / b;
            //int tsyalo = Convert.ToInt32(c);
            //float razlika = c - tsyalo;
            //Console.WriteLine(razlika);
        }
    }
}
