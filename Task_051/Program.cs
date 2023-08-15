// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся
//  на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

using System;
using static System.Console;

WriteLine("Введите количество строк массива: ");
int m = int.Parse(ReadLine()!);
WriteLine("Введите количество столбцов массива: ");
int n = int.Parse(ReadLine()!);
WriteLine();

int[,] array = GetArray(m, n);
PrintArray(array);
WriteLine();
WriteLine($"Сумма элементов главной диагонали последовательностей диагонали = {GetSum(array)}");

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(40);
        }
    }
    return result;
}

int GetSum (int[,] array1)
{
    int sum = 0;
    int min = array1.GetLength(0) < array1.GetLength(1) ? array1.GetLength(0) : array1.GetLength(1);
    for (int i = 0; i < min; i++)
    { 
        sum += array1[i,i];  
    }
    return sum;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}