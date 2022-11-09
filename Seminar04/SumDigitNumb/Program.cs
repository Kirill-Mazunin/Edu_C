
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Через строку решать нельзя.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigitNumb()
{
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine()!);
    int sum = 0;
    for (int i = 0; num > 0; i++)
    {
        sum += (num % 10);
        num = num / 10;
    }
    return sum;
}
Console.WriteLine("Сумма цифр введеного числа: " + SumDigitNumb());


