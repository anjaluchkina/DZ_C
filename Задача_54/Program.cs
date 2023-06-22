//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[linesVol, columnsVol];
FillArrayRandomNumbers(arr);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(arr);
CountArray(arr);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

void CountArray(int[,] arr) //создали массив счетчиков
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < arr.GetLength(1) - 1; z++)
            {
                if (arr[i, z] < arr[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
                {
                    int temp = 0;
                    (arr[i, z], arr[i, z + 1]) = (arr[i, z + 1], arr[i, z]);
                    // temp = arr[i, z];
                    // arr[i, z] = arr[i, z + 1];
                    // arr[i, z + 1] = temp;
                }
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(arr);
