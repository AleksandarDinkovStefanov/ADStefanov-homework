using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1: Напишете програма, която намира сбора на всичките четни елементи в масив.

            // Въвеждаме дължината на масива от конзолата
            Console.WriteLine("Enter array length:");
            int N = int.Parse(Console.ReadLine());
            int[] myArray = new int[N];
            int sum = 0;

            // Въвеждаме стойностите на масива една по една от конзолата
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Enter array value: ");
                myArray[i]=int.Parse(Console.ReadLine());
            }

            // Правим проверка за четност и сумираме
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] %2 ==0)
                {
                    sum += myArray[i];  //sum = sum + myArray[i];
                }
            }
            // Извеждаме сумата от четните числа с надпис
            Console.WriteLine("The sum of even array values is: {0}", sum);
        }
    }
}
