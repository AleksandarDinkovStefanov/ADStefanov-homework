using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 2:Напишете булев израз, който да проверява дали даден низ от
            // символи (string) е равен на „Hello”. Отпечатайте в конзолата
            // резултата от проверката.

            Console.WriteLine("Моля въведете низ от символи (string)");
            string text1 = Console.ReadLine();
            string text2 = "Hello";
            bool a = (text1 == text2);
            Console.WriteLine(a);
        }
    }
}
