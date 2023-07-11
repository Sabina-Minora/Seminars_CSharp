/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine()!);
double[] randomArray = new double[num];

void massive(int a)
{
    Random NewArray = new Random();
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = NewArray.NextDouble();
        Console.Write($"{randomArray[i]:F2} ");
    }

}

double Diff(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;

    while (i < randomArray.Length)
    {
        if (max < randomArray[i])
        max = randomArray[i];

        if (min > randomArray[i])
        min = randomArray[i];

        i = i + 1;
    }
    return max-min;
}

massive(num);
Console.Write($"Разница между максимальным и минимальным элементов массива: {Diff(randomArray):F2}");