﻿/* **Задача 48:** 
Задайте двумерный массив размера m на n, каждый элемент
массиве находится по формуле: A[i, j] = i + j.
Выведите полученный массив на экран.

m = 3, n = 4.

0 1 2 3
1 2 3 4
2 3 4 5 */

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int m=int.Parse(ReadLine()!);
Write("Введите количество столбцов массива: ");
int n=int.Parse(ReadLine()!);

int[,] array = GetArray(m, n);
PrintArray(array);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
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
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}