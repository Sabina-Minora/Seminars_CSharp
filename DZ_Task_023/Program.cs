/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */


Console.Clear();
Console.WriteLine("Введите любое число: ");
double N = double.Parse(Console.ReadLine()!);
double B = 1;

Console.WriteLine($"Это таблица кубов от 1 до {N}");

while (B <= N)
{
    double sqr = Math.Pow(B,3);
    Console.WriteLine(sqr);
    B++;
}