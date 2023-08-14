/* **Задача 42:**Напишите программу,
которая будет преобразовывать десятичное число в двоичное.

45 -> 101101
3 -> 11
2 -> 10 */

Console.Clear();
Console.WriteLine("Введите десятичное число: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write(DecimalToNum(num));
string DecimalToNum(int N)
{
    string binar = "";
    while(N > 0)
    {
        binar = Convert.ToString(N % 2) + binar;
        N = N / 2;
    }
    return binar;
}
