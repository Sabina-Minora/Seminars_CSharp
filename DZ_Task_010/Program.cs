/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Clear();
Console.Write("Введите любое трёхзначное число: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num >=100 && num <1000)
{
int mid = (num % 100 - num % 10) / 10;
System.Console.WriteLine($"Вторая цифра числа {num} является {mid}");
}
else
System.Console.WriteLine("Это число не трехзначное");