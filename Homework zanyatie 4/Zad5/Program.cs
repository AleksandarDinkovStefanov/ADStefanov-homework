using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която кара потребителя да въвежда числа и ги сумира. 
            // Края на програмата настъпва, единствено когато потребителя въведе числото 0.

            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter number");
                int chislo = int.Parse(Console.ReadLine());
                if (chislo != 0)
                {
                    sum += chislo; // sum = sum + chislo;
                    Console.WriteLine("The sum is " + sum);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
