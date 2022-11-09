// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Exponentiation()
{
int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
int res = A;
for (int i = 0; i < B - 1; i++)
{
    res = res * A; 
}
return res;
}
Console.Write(Exponentiation());