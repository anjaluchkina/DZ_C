// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-100, 100) / 10.0;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 3}    ");
        }
        Console.WriteLine("");
    }
}

Console.Clear();
System.Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine()); //строки
System.Console.WriteLine("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine()); // столбцы
double[,] array = new double[m, n];
FillArray(array);
PrintArray(array);
