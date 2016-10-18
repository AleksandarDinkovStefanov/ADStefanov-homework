using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 6: Напишете програма, която обръща стойностите на един масив. 

            // Задаваме масив
            string[] myArray = { "а", "л", "е", "н", "а", "ф" };

            // Изписваме го
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i]);
            }
            Console.WriteLine("    ");
            
            // Задаваме обърнатия масив:

            string[] myArray2 =new string [myArray.Length];
            // Присвояваме му обърнатите стойности:
            for (int i = 0; i < myArray2.Length; i++)
			{
                myArray2[i] = myArray[myArray.Length - i - 1];
			}
            // Изписваме обърнатия масив:
            for (int i = 0; i < myArray2.Length; i++)
			{
                Console.Write(myArray2[i]);
			}
            Console.WriteLine("");

            // Дълго решение:
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
            //    Console.WriteLine(myArray[i]);
            //}

            //// Задаваме втори масив:
            //int[] myArray2 = new int[myArray.Length];
            //// Задаваме стойностите на новия масив равно на тези на стария масив
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray2[i] = myArray[myArray.Length - i -1];
            //}

            //// Извеждаме стойностите на втория масив на екрана (за да ги видим):
            //Console.WriteLine("The values of the second array are: ");
            //for (int i = 0; i < myArray2.Length; i++)
            //{
            //    Console.WriteLine(myArray2[i]);
            //}
        }
    }
}
