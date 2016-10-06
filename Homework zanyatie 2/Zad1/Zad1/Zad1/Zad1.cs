using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Zad1
    {
        static void Main(string[] args)
        {
            // Задача 1: Напишете програма, която чете от конзолата 2 числа 
            // от тип int и отпечатва тяхната сума.

            Console.WriteLine("Въведи число");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведи второ число");
            int B = int.Parse(Console.ReadLine());
            int C = A + B;
            string result = "Сумата на числата е ";
            Console.WriteLine(result + C);
        }
    }
}
