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
            // Задача 7: Напишете програма, която проверява дали един масив е симетричен. 

            Console.WriteLine("Specify the lenghth of an array - enter positive integer: ");
            int[] myArray = new int[int.Parse(Console.ReadLine())];
           
            Console.WriteLine("Enter values for the array - integer values: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("The array values are: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i]+" ");
            }
            Console.WriteLine(" ");

            bool a = true;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] != myArray[myArray.Length - i - 1])
                {
                    a = false;
                    break;
                }
            }
            Console.WriteLine("Is the array symetric? {0}", a);

            



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
