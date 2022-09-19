// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;
class workhome
{
    public static void Main()
    {
        task56();
    }
    public static void task56()
    {
        Console.Write("Введите размер массива m = ");
        int m = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введите размер массива n = ");
        int n = Convert.ToInt16(Console.ReadLine());
        int[,] mas = new int[m, n];
        Random rnd = new Random();
        Console.WriteLine("Исходный массив:");
        int min = 99999;
        int numberstr = 0;
        for (int j = 0; j < n; j++)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                mas[i, j] = rnd.Next(0, 10);
                Console.Write($"{mas[i, j]} \t");
                sum += mas[i, j];
            }
            Console.WriteLine("Сумма элементов в стороке {0}", sum);
            if (sum < min)
            {
                numberstr = j;
                min = sum;
            }
            Console.WriteLine();
        }
        Console.WriteLine("Cтрока с наименьшей суммой элементов: {0}", numberstr + 1);
    }
}