using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadFromClassSwitch1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете цяло число");
            var a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    if (a % 2 == 0 )
                    {
                        Console.WriteLine("chetno");
                    }
                    else
                    {
                        Console.WriteLine("nechetno");
                    }
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    if (a % 3 == 0)
                    {
                        Console.WriteLine("deli se na 3 bez ostatak");
                    }
                    else
                    {
                        Console.WriteLine("ne se deli na 3 bez ostatak");
                    }
                    break;
                default:
                    if (a < 0)
                    {
                        Console.WriteLine("-");
                    }
                    else if (a == 0)
                    {
                        Console.WriteLine("0");
                    }
                    else
                    {
                        Console.WriteLine("+");
                    }
                    break;
            }
        }
    }
}
