//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
//на само себя).

//Пример:
// 4 - 16
// -7 - 49

Console.Clear();
Console.Write("ВВедите число: ");
int number = int.Parse(Console.ReadLine()!);
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");
int sqr1 = Convert.ToInt32(Math.Pow(number, 3));
Console.WriteLine($"Куб числа {number} равен {sqr1}");