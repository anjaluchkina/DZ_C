// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
FillArray(num);
Console.WriteLine("Массив: ");
PrintArray(num);
int sum = 0;

for (int i = 0; i < num.Length; i += 2)
    sum = sum + num[i];

Console.WriteLine($"всего {num.Length} чисел, сумма нечетных позиций {sum}");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}

void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}
