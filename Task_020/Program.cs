/* 20 Напишите программу,
которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.

A (3,6); B(2, 1)-> 5,09
A(7, -5); B(1, -1)-> 7,21
sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
double s = Math.Sqrt(...); */

Console.Clear();

Console.Write("Введите первую координату первой точки: ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите вторую координату первой точки: ");
double y1 = double.Parse(Console.ReadLine()!);

Console.Write("Введите первую координату второй точки: ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите вторую координату второй точки: ");
double y2 = double.Parse(Console.ReadLine()!);

double lenght = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine($"Длинна равна {lenght:f2}");