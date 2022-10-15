// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Ищем максимальное из трех чисел");
Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число ");
int c = int.Parse(Console.ReadLine()!);
if (b  <= a && a >= c)
{
    Console.Write("Максимальное из введенных чисел это ");
    Console.Write(a);
}
if (a <= b && b >= c)
{
    Console.Write("Максимальное из введенных чисел это ");
    Console.Write(b);
}
if (b <= c && c >= a)
{
    Console.Write("Максимальное из введенных чисел это ");
    Console.Write(c);
}