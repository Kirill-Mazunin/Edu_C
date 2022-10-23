// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubeBeforeN(int N)
{
    int x = 1;
    while (x <= N)
    {
        Console.Write(" " + Math.Pow(x, 3));
        x += 1;
    }
}

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
CubeBeforeN(N);