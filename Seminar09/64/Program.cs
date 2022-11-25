// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string DecNum(int N)
{
 if (1 <= N) return $"{N} " + DecNum(N - 1);
 else return String.Empty;
}
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(DecNum(N));
