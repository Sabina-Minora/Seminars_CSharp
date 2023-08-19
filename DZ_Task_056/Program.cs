/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка */

using System;
using static System.Console;

Clear();

WriteLine("Введите количество строк массива: ");
int m = int.Parse(ReadLine()!);
WriteLine("Введите количество столбцов массива: ");
int n = int.Parse(ReadLine()!);
WriteLine();

int[,] array = GetArray(m, n);
PrintArray(array);
WriteLine();

WriteLine($"Строка с наименьшей суммой - {GetRowNumber(array)}");

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        result[i, j] = new Random().Next(0, 20);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j], 5} ");
        }
        WriteLine();
    }
}

int GetRowNumber(int[,] array)
{
    int row = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum = minSum + array[0, i];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0; 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            row = i;
        }
    }
    return row;
}