using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Zad3
    {
        static void Main(string[] args)
        {
            // Задача 3: Направете програма, която приема две цели числа - съответно
            // страната и височината на триъгълник. Пресметнете лицето на
            // дадения триъгълник и я изведете на конзолата.

            Console.WriteLine("Въведете страна на триъгълник");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете прилежащата на страната височина в триъгълника");
            int Ha = int.Parse(Console.ReadLine());
            string litse = "Лицето на триъгълника е равно на ";
            float A = (float)a;
            float HA = (float)Ha;
            float res = (A * HA / 2);
            Console.WriteLine(litse + res);
            //ако разделиш на double ще се получи резултат със запетая
        }
    }
}
