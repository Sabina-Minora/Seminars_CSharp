/* ЛЕКЦИЯ 4: Двумерные массивы и рекурсия.
                                                         
Двумерный массив указывается:
                       // строки столбцы
string[,] table = new string [2, 3];
// String.Empty
// table [0,0] table [0,1] table [0,2] ... table [0,4]
// table [1,0] table [1,1] table [1,2] ... table [1,4]


int[,] matrix = new int [5, 8]

*/


/*Console.Clear();

string[,] table = new string[2,5];
table[0, 3] = "text";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.Write($" - | {table[rows, columns]} - ");
    }
    Console.WriteLine();
}  */

Console.Clear();

void PrintArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }

}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int [3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);



