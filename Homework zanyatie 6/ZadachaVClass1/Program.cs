using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaVClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма,  която пълни двумерен масив с размер 4х4. Пълненето става 
            // хоризонтално. Обходете повторно матрицата и умножете всички нечетни числа 
            // по 2, така че всички числа да станат четни или 0.

            int[,] matrix = new int[4, 4];
            int counter = 0;

            // Пълни матрицата с числа от 0 до дължината на матрицата;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {  
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = counter; ;
                    counter++;
                }
            }
            // Извежда матрицата в конзолата
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + "    ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            // Умножава нечетните стойности на матрицата по 2
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] % 2 != 0)
                    {
                        matrix[row, col] = matrix[row, col] * 2;
                    }
                }
            }
            // Извежда матрицата (вече умножена по 2) в конзолата
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + "    ");                  
                }
                Console.WriteLine("");
            }
        }
    }
}
