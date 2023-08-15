/*
**Задача 49:** Задайте двумерный массив.
Найдите элементы, у которых оба индекса чётные,
и замените эти элементы на их квадраты.

Например, изначально массив выглядел вот так:

1 4 7 2
5 9 2 3
8 4 2 4
1 2 3 4

Новый массив будет выглядеть вот так:

1 4 7 2
5 **81** 2 **9**
8 4 2 4
1 **4** 3 **16**  */


using System;
using static System.Console;

WriteLine("Введите количество строк массива: ");
int m = int.Parse(ReadLine());
WriteLine("Введите количество столбцов массива: ");
int n = int.Parse(ReadLine());

int[,] array = GetArray(m, n, 0, 10);
PrintArray(array);

WriteLine();

int[,] array1 = GetSqr(array);
PrintArray(array1);

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

int[,] GetSqr(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array1[i, j] *= array1[i, j];
            }
        }
    }
    return array1;
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

