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
            // Задача 2: Напишете програма, която позволява на потребителя 
            // да попълва масив с размери 3х4. Изведете масива на екрана.

            // Задаваме матрица 3х4
            double[,] matrix = new double[3, 4];
            // Попълваме матрицата от конзолата с цикъл for
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col <  matrix.GetLength(1); col++)
                {
                    matrix[row, col] = double.Parse(Console.ReadLine()); 
                }
            }
            // Извеждане на матрицата в конзолата
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
