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
            // Задача 5: Прекопирайте един масив от цели числа в друг масив. 
           
            // Задаваме първия масив:
            int[] myArray = { 1, 2, 3, 4, 5 };
            
            // Извеждаме първия масив на екрана:
            Console.WriteLine("The values of the first array are: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine("");


            // Задаваме новия масив еднакъв с първия
            int[] myArray2 = new int[myArray.Length];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray2[i] = myArray[i];
            }

            // Извеждаме новия масив на екрана:
            Console.WriteLine("The values of the second array are: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine("");
            




            //// Дълго решение:
            //// Първо задаваме "ръчно"дължината N на масив:
            //Console.WriteLine("Enter the array's length - positive integer: ");
            //int N = int.Parse(Console.ReadLine());
            //int[] myArray = new int[N];

            //// Задаваме "ръчно" стойностите на всеки индекс на масива:
            //Console.WriteLine("Enter array's values: ");
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}

            //// Извеждаме стойностите на масива на екрана (за да ги видим):
            //Console.WriteLine("The values of the first array are: ");
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine("for index {0}, the value is {1}", i, myArray[i]);
            //}

            //// Задаваме втори масив:
            //int[] myArray2 = new int[myArray.Length];
            //// Задаваме стойностите на новия масив равно на тези на стария масив
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray2[i] = myArray[i];
            //}

            //// Извеждаме стойностите на втория масив на екрана (за да ги видим):
            //Console.WriteLine("The values of the second array are: ");
            //for (int i = 0; i < myArray2.Length; i++)
            //{
            //    Console.WriteLine("for index {0}, the value is {1}", i, myArray2[i]);
            //}
        }
    }
}
