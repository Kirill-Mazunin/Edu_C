// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Четные числа от 1 до N");
Console.Write("Введите число ");
int count = 1;  
int N = int.Parse(Console.ReadLine()!);
while (count <= N)
{
    if (count % 2 == 0)
    {
        Console.Write(" ");
        Console.Write(count);
    }
    count++;
}

