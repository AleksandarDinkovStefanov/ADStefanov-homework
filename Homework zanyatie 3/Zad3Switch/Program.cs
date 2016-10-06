using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3Switch
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

            switch (a)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    Console.WriteLine("Valid card");
                    break;
               default:
                    Console.WriteLine("Invalid card Input");
                    Console.WriteLine("Enter cart value: 2,3,4,5,6,7,8,9,10,J,Q,K or A");
                    break;
            }         
        }
    }
}
