/* *Задача 53:**
Задайте двумерный массив.
Напишите программу, которая поменяет местами первую и последнюю строку массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2 */


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
PrintArray(FindingNumber(array));

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

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],5} ");
        }
        WriteLine();
    }
}
// Меняет первую с последней строки.
int[,] FindingNumber(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(1); i++)
    {
        int b = array2[0, i];
        array2[0, i] = array2[array2.GetLength(0) - 1, i];
        array2[array2.GetLength(0) - 1, i] = b;
    }
    return array2;
}

/* // Можно ввести сроки, которые нужно поменять.

Write("Введите строку 1: ");
int a1 = int.Parse(ReadLine());
Write("Введите строку 2: ");
int b1 = int.Parse(ReadLine());
ChangeRows(array, a1, b1);
PrintArray(array);

void ChangeRows(int[,] inArray, int a, int b)
{
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        int k = inArray[a - 1, i];
        inArray[a - 1, i] = inArray[b - 1, i];
        inArray[b - 1, i] = k;
    }
}
*/
