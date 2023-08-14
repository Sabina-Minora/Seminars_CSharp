/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

using System;
using static System.Console;

Clear();
WriteLine("Введите последовательно через пробел несколько цифр: ");
int[] numbers = GetArrayFromString(Console.ReadLine()!);

WriteLine($"Количество чисел больше 0 –> {GetCountPositiveElements(numbers)}");
WriteLine();

int[] GetArrayFromString(string stringArray)
{
    string[] numS = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}

int GetCountPositiveElements(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if(item>0) count++;
    }
    return count;
}

