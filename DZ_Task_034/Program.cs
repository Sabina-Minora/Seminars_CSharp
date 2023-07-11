/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();

Console.Write("Введите количесвто элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine()!);  

int[] randomArray = new int[size];

void massive(int size)
{
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(100, 1000);
        Console.Write(randomArray[i] + " ");
    }
}

int quan(int[] randomArray)
{
    int quan = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] % 2 == 0)
        quan = quan + 1;
    }
    return quan;
}

massive(size);
Console.Write($"Количество чётных чисел в массиве: {quan(randomArray)}");