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
            // Задача 5: Напишете програма, която приема 2 символни низа (string) като
            // вход, и изведете като резултат конкатениран string със „_“
            // между двата входни низа.

            string a = "умен";
            char _ = '_';
            string b = "съм";
            string result = a + _ + b;
            Console.WriteLine(result);
        }
    }
}
