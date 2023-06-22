// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

System.Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine()); //m - строки
System.Console.WriteLine("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine()); //n - столбцы

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

void FillArray(int[,] array)
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
        Console.WriteLine();
    }
}

int SumElement(int[,] array, int i)
{
    int Sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        Sum += array[i, j];
    }
    return Sum;
}

int minSum = 0;
int Sum = SumElement(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int temp = SumElement(array, i);
    if (Sum > temp)
    {
        Sum = temp;
        minSum = i;
    }
}

Console.WriteLine($"\n{minSum + 1} - строкa с наименьшей суммой ({Sum}) ");
