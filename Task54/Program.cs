// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

using System;
class workhome
{
    public static void Main()
    {
        task54();
    }

    public static void task54()
    {
        Console.Write("Введите размер массива m = ");
        int m = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введите размер массива n = ");
        int n = Convert.ToInt16(Console.ReadLine());
        int[,] mas = new int[m, n];
        Random rnd = new Random();
        Console.WriteLine("Исходный массив:");
        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < m; i++)
            {
                mas[i, j] = rnd.Next(0, 10);
                Console.Write($"{mas[i, j]} \t");
            }
            Console.WriteLine();
        }
        //Сортируем массив 
        for (int j = 0; j < n; j++)
        {
            bool sortfull = true;
            int count = m;
            while (sortfull)
            {
                count--;
                bool sort = false;
                for (int i = 0; i < count; i++)
                {
                    if (mas[i, j] < mas[i + 1, j])
                    {
                        int x = mas[i, j];
                        mas[i, j] = mas[i + 1, j];
                        mas[i + 1, j] = x;
                        sort = true;
                    }
                }
                sortfull = sort;
            }
        }
        //Выводим массив
        Console.WriteLine("Полученный массив:");
        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < m; i++)
            {
                Console.Write($"{mas[i, j]} \t");
            }
            Console.WriteLine();
        }
    }
}