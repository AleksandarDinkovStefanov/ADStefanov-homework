using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача4: Напишете програма, която търси число в масив от числа  
            // и връща индекса на първото намерено число.

            // може да зададенм числото и от конзолата (ако искаме)

            int[] myArray = {2,3,5,11,13,6,5,3,2,11};
            int counter = 1; // защото индексите започват от 0
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine("");

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i]!= 5)
                {
                    counter++; 
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("първото число 5 е на позиция с индекс: {0}", counter);

            // ЗАЩО НЕ СТАВА С DO WHLE ???
            //for (int j = 0; j < myArray.Length; j++)
            //{
            //    do
            //    {
            //       counter = counter + 1;
            //    } while (myArray[j]!= 5);
            //}
            //Console.WriteLine("първото число 5 е на позиция с индекс: {0}", counter);
        }
    }
}
