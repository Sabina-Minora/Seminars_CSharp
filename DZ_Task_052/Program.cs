/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2  // a a1 a2   (a+b+c)/n ...
5 9 2 3  // b b1 b2    
8 4 2 4  // c c1 c2
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.  */

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int m = int.Parse(ReadLine()!);
Write("Введите количество столбцов массива: ");
int n = int.Parse(ReadLine()!);

int[,] array = GetArray(m, n, 0, 10);
PrintArray(array);

double[] averageColum=GetResultArray(array);
WriteLine($"Среднее арифметическое каждого столбца = {String.Join("; ", averageColum)}");

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

double[] GetResultArray(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j,i];
        }
        result[i] = Math.Round(sum/array.GetLength(0),2);
    }
    return result;
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