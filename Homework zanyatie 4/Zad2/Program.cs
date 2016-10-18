using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която отпечатва на конзолата числата от 1 до N,
            // които не се делят на 3 или 7. Числото N се въвежда от конзолата.
            
            Console.WriteLine("Enter integer");
            var N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++ )
			{
                if (i % 3 != 0 && i % 7 != 0)
                {
                     Console.WriteLine(i);
                }

            }   
        }
    }
}
