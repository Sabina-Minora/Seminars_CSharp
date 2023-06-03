/*1.Напишите программу, которая на вход принимает два числа и проверяет,
является ли первое число квадратом второго.

a = 25; b = 5->да
a = 2 b = 10->нет
a = 9; b = -3->да
a = -3 b = 9->нет*/

Console.Clear();
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
//пример 1
if(num2 == num1 * num1)
{
Console.WriteLine($"Число {num1} является квадратом числа {num2}");
}
else
{
Console.WriteLine($"Число {num1} не является квадратом числа {num2}");
}
//пример 2
if(Math.Pow(num1, 2) == num2)
{
Console.WriteLine($"Число {num1} является квадратом числа {num2}");
}
else
{
Console.WriteLine($"Число {num1} не является квадратом числа {num2}");
}


/*
if(Math.Pow(num2, 2) == num1);

Console.Clear();
Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());

int num3;

if(num2 == num1 * num1)
{
Console.WriteLine($"Число {num1} является квадратом числа {num2}");
}
else
{
Console.WriteLine($"Число {num1} не является квадратом числа {num2}");
}*/