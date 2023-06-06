using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22
{
    class Program
    {
        static void Main()
        {
            int n = 3;
            //int[,] matrix = new int[n,n];
            // Random rnd = new Random();    
            //int[,] matrix = new int[,] { { 4, 7, 9 }, { 6, 8, 5 }, { 2, 7, 1 } };//не симметрична 
             int[,] matrix = { { 1, 2, 3 }, { 2, 4, 5 }, { 3, 5, 6 } };// главная диагональ
            // int[,] matrix = new int[,] { { 3, 2, 1 }, { 4, 1, 2 }, { 1, 4, 3 } };//  побочная диагонали 
            // int[,] matrix = new int[,] { { 6, 2, 3 }, { 2, 4, 2 }, { 3, 2, 6 } };// главная и побочная
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //  matrix[i, j] = rnd.Next(0, 11);  
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }

            bool MainDiagonal = true;
            bool SecondaryDiagonal = true;

            // Проверяем симметричность относительно главной диагонали
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        MainDiagonal = false;
                        break;
                    }
                }
                if (!MainDiagonal) break;
            }

            // Проверяем симметричность относительно побочной диагонали
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != matrix[matrix.GetLength(0) - j - 1, matrix.GetLength(1) - i - 1])
                    {
                        SecondaryDiagonal = false;
                        break;
                    }
                }
                if (!SecondaryDiagonal) break;
            }

            if (MainDiagonal && SecondaryDiagonal)
            {
                Console.WriteLine("Матрица симметрична относительно главной и побочной диагонали");
            }
            else if (MainDiagonal)
            {
                Console.WriteLine("Матрица симметрична относительно главной диагонали");
            }
            else if (SecondaryDiagonal)
            {
                Console.WriteLine("Матрица симметрична относительно побочной диагонали");
            }
            else
            {
                Console.WriteLine("Матрица не симметрична");
            }
            Console.ReadLine();
        }
    }
}