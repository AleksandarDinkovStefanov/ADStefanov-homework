using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaad1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи число");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведи второ число");
            int B = int.Parse(Console.ReadLine());
            int C = A + B;
            //string result = "Сумата на числата е ";
            Console.WriteLine("Сумата на числата е " + C);
        }
    }
}
