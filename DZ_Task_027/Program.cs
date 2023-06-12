/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

/* (Неудачная попытка :/)

int[] array = num; // {0, 0, 0 ... 0} {1, 7, 5}
int n = array.Length;//                 0  1  2
int index = 0;

// int sum = int.Convert.ToInt32(Console.ReadLine()!);

void FillArray(int[] sum)
{
    int length = sum.Length;
    while (index < length)
    {
        sum = a += b ;
        index++;
    }
} */


Console.Clear();

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine()!);
int len = Length(num);

int Length(int num)
{
    int index = 0;
    while (num > 0)
    {
        num /= 10;
        index++;
    }
    return index;
}
int Sum(int num, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.Write($"Суммой всех цифр числа {num} равно: {Sum(num,len)}");