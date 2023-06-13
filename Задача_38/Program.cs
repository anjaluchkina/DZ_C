// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] num = new double[size];
FillArray(num);
Console.WriteLine("Mассив: ");
PrintArray(num);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < num.Length; i++)
{
    if (num[i] > max)
    {
        max = num[i];
    }
    if (num[i] < min)
    {
        min = num[i];
    }
}

Console.WriteLine(
    $"всего {num.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}"
);
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArray(double[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = Convert.ToDouble(new Random().Next(10, 100)) / 10;
    }
}

void PrintArray(double[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ; ");
    }
    Console.WriteLine();
}
