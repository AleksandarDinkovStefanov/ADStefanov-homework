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
            int a = 0;
            a ++;
            while (a <= 20)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);  
                }
                a++;
            }
        }
    }
}
