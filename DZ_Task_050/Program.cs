/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int m=int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int n=int.Parse(ReadLine());

int[,] array = GetArray(m, n, 0, 30);
PrintArray(array);

Write("Введите значение элемента: ");
int element=int.Parse(ReadLine());

if(FindElement(array,element))
{
    WriteLine("Элемент присутствует в массиве");
}
else
{
    WriteLine("Элемент не найден в массиве");
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max+1);
        }

    }
    return result;
}

bool FindElement(int[,] array, int elem)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j]==elem) return true;
        }
    }
    return false;
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