/*
Задайте двумерный массив размером m × n, 
заполненный случайными целыми числами

mas = [[1, 2, 3],
      [4, 5, 6]]
mas[0][2]

*/


Console.Clear();

Consol.WriteLine("Введите количество строк массива: ");
int raws = int.Parse(Console.ReadLine()!);

Consol.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(raws, columns, 0, 10)
Console.Print(array);

int[,] GetArray[int m, int n, int MinValue, int MaxValue]
{
    int[,] result = result[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] InArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}