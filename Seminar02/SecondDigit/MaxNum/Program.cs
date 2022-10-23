// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Ищем максимальное число");
Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.Write("В этой паре максимальное число  ");
    Console.Write(a);
}
if (b > a)
{
    Console.Write("В этой паре максимальное число  ");
    Console.Write(b);
} 
if (a == b)
{
    Console.WriteLine("Вы ввели равные числа");
} 