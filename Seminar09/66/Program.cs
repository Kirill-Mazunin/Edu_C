// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRec(int M, int N)
{
 if (N < M) return 0;
 else return M + SumRec(M + 1, N);
}

int M = int.Parse(Console.ReadLine()!);
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumRec(M, N)); 