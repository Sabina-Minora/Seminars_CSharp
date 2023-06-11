/*Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23

Пример:if((a > b || a < c) && (x > b || x < c) || d == 5))
  
 14  ->  нет
 46  ->  нет
 161 ->  да*/



Console.Clear();
Console.WriteLine("Введите любое целое число: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"Число {number} кратно 7 и 23");
}
else 
{
     Console.WriteLine($"Число {number} не кратно 7 и 23");
}