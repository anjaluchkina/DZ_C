// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
FillArrayRandomNumbers(num);
Console.WriteLine("Вот наш массив: ");
PrintArray(num);
int count = 0;

for (int z = 0; z < num.Length; z++)
    if (num[z] % 2 == 0)
        count++;

Console.WriteLine($"всего {num.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.WriteLine();
}
