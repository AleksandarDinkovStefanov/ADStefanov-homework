using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_ci_sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());
            if (size > 1 && size < 10)
            {
                Console.WriteLine("Imput is ok!");
            }
            else
            {
                Console.WriteLine("Wrong input! Enter number from 2 to 9");
            }

            int[,] matrix = new int[size, size];

            int[] array = new int[matrix.Length];

            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = array[i] + sum;
            }
            Console.WriteLine();
            Console.WriteLine(sum);



            int counter = 1;
            int counter2 = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[col, row] = array[counter2];
                    counter++;
                    counter2++;
                }
            }

            Console.WriteLine();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}
