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
            // Напишете програма, която приема от конзолата 2 числа a и b (b > a) 
            // и изкарва на екрана всички числа от a до b, които се делят на 3 без остатък 

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (b > a)
            {
                for (int i = a; i < b; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.Write(i);
                        Console.WriteLine(" ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong input, enter b>a");
            }
    
        }
    }
}
