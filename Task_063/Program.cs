﻿/* **Задача 63:**Задайте значение N.Напишите программу,
 которая выведет все натуральные числа в промежутке от 1 до N.

N = 5-> "1, 2, 3, 4, 5"

N = 6-> "1, 2, 3, 4, 5, 6" */

using System;
using static System.Console;

Clear();

WriteLine("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);

for (int i = m; i < n; i++)
{
    Write($"{i}, ");
}

WriteLine();
//WriteLine(PrintNumbers(n));

string PrintNumbers(int n)
{
    if (n == 1)
    {
        //WriteLine(1);
        return "1";
    }
    string s = PrintNumbers(n - 1) + ", " + n.ToString();
   // WriteLine(s);
    return s;
}