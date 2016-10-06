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
            // Класическото тесте карти се състои от 13 различни вида карти
            // съответно 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Направете
            // програма, която приема от конзолата карта и принтира
            // "Валидна карта", ако въведената карта представлява валидна
            // карта, и съответно принтира "Невалидна карта", ако е
            // невалидна карта. 

            Console.WriteLine("Enter cart value: 2,3,4,5,6,7,8,9,10,J,Q,K or A");
            string a = (Console.ReadLine());

            if (a == "2")
            {
                Console.WriteLine("Valid card");
            }
            else if (a == "3")
            {
                Console.WriteLine("Valid card");
            }
            else if (a == "4")
            {
                Console.WriteLine("Valid card");
            }
            else if (a == "5")
            {
                Console.WriteLine("Valid card");
            }
            else if (a == "6")
            {
                Console.WriteLine("Valid card");
            }
            else if (a == "7")
            {
                Console.WriteLine("Valid card");
            }
            else if (a == "8")
            {
                Console.WriteLine("Valid card");
            }
            else if (a == "9")
            {
                Console.WriteLine("Valid card");
            }
            else if (a == "10")
            {
                Console.WriteLine("Valid card");
            }
            else if (a == "J")
            {
                Console.WriteLine("Valid card");
            }
            else if (a == "Q")
            {
                Console.WriteLine("Valid card");
            }
            else if (a == "K")
            {
                Console.WriteLine("Valid card");
            }
            else if (a == "A")
            {
                Console.WriteLine("Valid card");
            }
            else
            {
                Console.WriteLine("Invalid cart input");
            }
        }
    }
}
