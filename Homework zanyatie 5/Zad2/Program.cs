using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Въвеждаме масив с дължина N
            Console.WriteLine("Enter array lenght:");
            int N = int.Parse(Console.ReadLine());
            double[]myArray = new double[N];

            // Въвеждаме първите 2 стойности от редицата на Фибоначи 
            myArray[0] = 1;
            myArray[1] = 1;

            // С цикъла for задаваме 3 ата и всички следващи стойности на 
            // редицата на Фибоначи, като започваме от i = 2
            for (int i = 2; i < N; i++)
            {
                myArray[i] = myArray[i-2]+myArray[i-1];
            }
            // Изписваме стойностите на масива (една под друга)
            // като започваме вече от първата, т.е. от индекс i = 0;
            Console.WriteLine("Array values are:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            // Сумираме стойностие на масива
            // за целта въвеждаме counter sum = 0
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum = sum + myArray[i];
            }
            // Изписваме сбора от числата на Фибоначи
            Console.WriteLine("The sum of Fibonachi numbers in array with length {0} is {1}", N, sum);
        }
    }
}
