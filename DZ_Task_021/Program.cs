/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();

Console.Write("Введите X1: ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите Y1: ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите Z1: ");
double z1 = double.Parse(Console.ReadLine()!);

Console.Write("Введите X2: ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите Y2: ");
double y2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите Z2: ");
double z2 = double.Parse(Console.ReadLine()!);


double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow(y2 - y1, 2)) + Math.Pow((z2 - z1), 2);

//Не могу найти ошибку, программа считает, но выдаёт неправильный результат

Console.WriteLine($" Длинна равна {d:f2}");
