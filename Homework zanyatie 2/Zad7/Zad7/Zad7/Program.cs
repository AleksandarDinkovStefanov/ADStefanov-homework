using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 7: Напишете програма, която приема два стринга като вход. След
            // това проверява дали 2рия стринг се съдържа в 1вия. Покажете
            // резултата от проверката на конзолата.

            Console.WriteLine("Въведете текст");
            string A = Console.ReadLine();
            Console.WriteLine("Въведете текст 2");
            string B = Console.ReadLine();
            bool amadali = A.Contains(B);
            Console.WriteLine(amadali);
        }
    }
}
