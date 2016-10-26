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
            // Задача 1: Напишете програма, която обхожда предварително създаден 
            // двумерен масив от числа и извежда на екрана само четните.

            // Въвеждане на Матрица
            double[,] matrix = 
            {    
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12}
            };
            // Извеждане на матрицата в конзолата 
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            // Извеждане четните членове на матрицата в конзолата 
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] % 2 == 0)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }           
                }
            }
        }
    }
}
