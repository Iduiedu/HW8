// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

using System;
class workhome
{
    public static void Main()
    {
        task58();
    }

     public static void task58()
    {
        Console.Write("Введите размер массива m = ");
        int m = Convert.ToInt16(Console.ReadLine());
        int[,] mas = new int[m, m];
        int[,] mas2 = new int[m, m];
        Random rnd = new Random();
        Console.WriteLine("Исходный массив 1:");
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < m; i++)
            {
                mas[i, j] = rnd.Next(0, 10);
                Console.Write($"{mas[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Исходный массив 2:");
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < m; i++)
            {
                mas2[i, j] = rnd.Next(0, 10);
                Console.Write($"{mas2[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Полученный массив:");
        int[,] masr = new int[m, m];
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas2.GetLength(1); j++)
            {
                for (int k = 0; k < mas2.GetLength(0); k++)
                {
                    masr[i, j] += mas[i, k] * mas2[k, j];
                }
                Console.Write($"{masr[i, j]} \t");
            }
            Console.WriteLine();
        }
    }
}