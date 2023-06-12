/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.

Пример:

5 -> 1, 4, 9, 16, 25.

2 -> 1,4*/


Console.Clear();
Console.WriteLine("Введите любое число: ");

/* Математическое решение:
double num = double.Parse(Console.ReadLine());
double B = 1;

while (B <= num)
{
    double sqr = Math.Pow(B,2);
    Console.WriteLine(sqr);
    B++;
} 
*/
// Решение через массив:
 int N = int.Parse(Console.ReadLine()!);

 int[] result = new int[N];

 for (int i = 1; i <= N; i++)
     result[i - 1] = i * i;
     
 for (int i = 0; i < N; i++)
     Console.Write($"{result[i]} ");