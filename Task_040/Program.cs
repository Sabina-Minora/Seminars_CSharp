/*  **Задача 40:** Напишите программу, 
которая принимает на вход три числа и проверяет, может ли 
существовать треугольник с сторонами такой длины. */

/* Console.Clear();

Console.WriteLine("Введите длинну сторон через пробел: ");
int AB = Convert.ToInt32(Console.ReadLine());
int BC = Convert.ToInt32(Console.ReadLine());
int CA = Convert.ToInt32(Console.ReadLine());

if(IsTriangle(AB, BC, CA))
{
    Console.WriteLine("Треугольник с такими сторонами существует.");
}
else
{
    Console.WriteLine("Треугольник с такими сторонами НУ существует.");
}

bool IsTriangle(int a, int b, int c)
{
    return (((a + b) > c) && ((a + c) > b) && ((b + c) > a));
} */


Console.Clear();

Console.WriteLine("Введите длинну сторон через пробел: ");

string[] st = Console.ReadLine().Split(" ");
int a = int.Parse(st[0]);
int b = int.Parse(st[1]);
int c = int.Parse(st[2]);

if (IsTriangle(a, b, c)){
    Console.WriteLine("Треугольник с такими сторонами существует.");
}
else
{
    Console.WriteLine("Треугольник с такими сторонами НЕ существует.");
}

bool IsTriangle(int a, int b, int c){
    return (((a + b) > c) && ((a + c) > b) && ((b + c) > a));
}