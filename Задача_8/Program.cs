//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int start = 2;

while (start <= number) // меньше либо равно
{
    System.Console.WriteLine(start + " ");
    start = start + 2;
}
