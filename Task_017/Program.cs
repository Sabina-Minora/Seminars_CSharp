/*Напишите программу, которая принимает на вход координаты точки (X и Y), 
 причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
в которой находится эта точка. */


Console.Clear();

Console.Write("Введите X: ");
int X = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine()!);

if(X > 0 && Y > 0){
    Console.WriteLine("Первая четверть (х > 0, y > 0)");
}else if(X < 0 && Y > 0){
    Console.WriteLine("Вторая четверть (х < 0, y > 0)");
}else if(X < 0 && Y < 0){
    Console.WriteLine("Третья четверть (х < 0, y < 0)");
} else if(X > 0 && Y < 0){
    Console.WriteLine("Четвертая четверть (х > 0, y < 0)");
} else if (X == 0 || Y == 0)
    Console.WriteLine("На оси, (х = 0 и/или y = 0)");