using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadFromClassSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Направете програма, която чете едно 
            // цяло число от конзолата. Ако числото е
            // в интервала от 1 до 5, нека да изписва
            // дали е четно или нечетно. Ако е в
            // интервала от 6 до 15, нека да извежда
            // дали се дели на 3 без остатък.  Ако не
            // попада в споменатите интервали, то
            // нека да ни казва дали е положително,
            // отрицателно или нула.
            
            Console.WriteLine("Enter integer");
            int a = int.Parse(Console.ReadLine());

            switch (a)
	{
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    bool b = a % 2 == 0;
                    Console.WriteLine("Is the integer even ?");
                    Console.WriteLine(b);
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
                    bool c = a % 3 == 0;
                    Console.WriteLine("Deli li se bez ostatak na 3 ?");
                    Console.WriteLine(c);
                    break;
		        default:

                    Console.WriteLine();
                break;
 	}

            //if (a >= 1 && a <= 5)
            //{
            //    if (a % 2 == 0)
            //    {
            //        Console.WriteLine("Integer is even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Integer is odd");
            //    }
            //}
            //else if (a >= 6 && a <= 15)
            //{
            //    if (a % 3 == 0)
            //    {
            //        Console.WriteLine("Bez ostatak");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ostatak ima");
            //    }
            //}
            //else
            //{
            //    if (a > 0)
            //    {
            //        Console.WriteLine("Int is positive");
            //    }
            //    else if (a < 0)
            //    {
            //        Console.WriteLine("Int is negative");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Int is zero");
            //    }
        }
    }
}
