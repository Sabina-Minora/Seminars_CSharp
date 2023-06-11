/*12 Напишите программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому. Если второе число не кратно числу первому,
то программа выводит остаток от деления.

 34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/


Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 % num2 == 0)
{
    Console.Write($"Число {num1} кратно числу {num2}");
}
else
{
    //int remains = num1 % num2;
    Console.WriteLine($"Число {num1} не кратко числу {num2}, остаток {num1 % num2}");
}
