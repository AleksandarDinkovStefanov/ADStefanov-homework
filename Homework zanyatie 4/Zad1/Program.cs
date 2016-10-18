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
            //Напишете програма, която отпечатва на конзолата 
            // числата от 1 до N. Числото N се въвежда от конзолата.
            
            Console.WriteLine("Enter Integer");
            int a = 1;
            var N = int.Parse(Console.ReadLine());
            while (a <= N)
            {
                Console.WriteLine(a);
                a++;
            }



            // Вар.2:
            //int a = 0;
            //var N = int.Parse(Console.ReadLine());
            //do
            //{
            //    a++;
            //    Console.WriteLine(a); 
            //} while (a < N);

        }
    }
}
