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
            // Задача:
            // Потребителят трябва да може да въведе число от 2 до 9, което 
            // число представлява едната страна на квадратен двумерен масив (матрица).
            // Програмата трябва да може да пресметне колко е броят на необходимите 
            // елементи, с който може да се попълни квадратният двумерен масив и да 
            // създаде едномерен масив с тази дължина. Потребителят трябва да може 
            // да въведе толкова стойности, че да попълни едномерния масив. След като 
            // едномерният масив е попълнен, той трябва да бъде обходен, за да се 
            // изчисли общата сума от всичките въведени стойности. Сумата да се изпише 
            // на екрана. В двумерния масив трябва да се попълнят стойностите от едномерния.
            // Попълването на двумерния масив трябва да стане вертикално (колона по колона).

            int size = int.Parse(Console.ReadLine());
            if (size > 1 && size < 10)
            {
                Console.WriteLine();
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

            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[col, row] = array[counter];
                    counter++;
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
