// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-30, 31);
    }
    System.Console.WriteLine();
}

void PrintArray(int[,] array)
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

void FindElementArray(int[,] findelement, int usernum) // массив, название, значение введеное пользователем.
{
    bool find = false;
    for (int i = 0; i < findelement.GetLength(0); i++)
    {
        for (int j = 0; j < findelement.GetLength(1); j++)
        {
            if (findelement[i, j] == usernum) // сравнение текущего значение и с тем что пользователь ввел
                System.Console.WriteLine("Значение находится по координатам " + i + " " + j);
            find = true; // если нашли присваиваем
        }
    }
    if (!find) // если переменная find = false, тогда
        System.Console.WriteLine("Такого значения в массиве нет ");
    Console.WriteLine("");
}

Console.Clear();

System.Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine()); //строки
System.Console.WriteLine("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine()); // столбцы
int[,] array = new int[m, n];
System.Console.WriteLine("Введите значение");
int num = Convert.ToInt32(Console.ReadLine());
FillArray(array);
FindElementArray(array, num);
PrintArray(array);
