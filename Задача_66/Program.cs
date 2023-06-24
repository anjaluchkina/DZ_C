// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummaRec(int M, int N)
{
    if (M == N)
        return N;
    return N + SummaRec(M, N - 1);
}

System.Console.WriteLine("Введите элемент M ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите элемент N ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма элементов от {M} до {N} равна: {SummaRec(M, N)}");
