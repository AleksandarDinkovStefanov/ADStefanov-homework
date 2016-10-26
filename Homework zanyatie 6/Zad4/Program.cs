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
            // Напишете програма, която принтира на екрана числата от 30 до 1 
            // в обратен ред, подредени в 5 реда и 6 колони. Да се реши с двумерен масив.

            // Задаваме матрица 5х6 и я запълваме с числата от 30 до 1, с counter --
            double[,] matrix = new double[5, 6];
            double counter = 30;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrix[row, col] + counter;
                    counter--;
                }
            }
            // Извеждаме резултатната матрица за да я видим
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");     
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            // Извеждаме матрицата в обратен for (forr) в конзолата
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    Console.Write(matrix[row, col] + " ");
                }       
                Console.WriteLine();
            }
        }
    }
}
