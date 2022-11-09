// Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.

// 452 -> 3
// 82 -> 2
// 9,012 ->4

void LenDigNumDouble(double num)
{
    int j = 0;
    int integer = (int)num;
    int integer2 = (int)num;
    int i = 0;
    while (integer > 0) { integer /= 10; i++; }
    while (integer2 != num)
    {
        num *= 10;
        j++;
        integer2 = (int)num;
    }
    Console.Write(j + i);
}

Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());
LenDigNumDouble(num);