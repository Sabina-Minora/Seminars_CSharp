/* **Задача 55:**Задайте двумерный массив.
Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7 */

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


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        result[i, j] = new Random().Next(0, 100);
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

void ChangeRowsColumns(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(1); i++)
    {
        for (int j = 0; j < array2.GetLength(0); j++)
        {
            Write($"{array2[j, i], 5}");
        }
        WriteLine();
    }
}

/*int[,] ChangeRowsColumns(int[,] array2)
{
    int[,] arrayNew = new int[array2.Length];
    for (int i = 0; i < array2.GetLength(1); i++)
    {
        for (int j = 0; j < array2.GetLength(0); j++)
        {
            arrayNew[i,j] = array2[j,i];
            Write($"{array2[j,i], 5}");
        }
        WriteLine();
    }
    return arrayNew;
} */


WriteLine();
ChangeRowsColumns(array);