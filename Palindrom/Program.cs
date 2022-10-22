// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int LengthNumber(int num)
{
    int length = 0;
    while (num > 0)
    {
        num = num / 10;
        length++;
    }
    return length;
}

int DigitInNum(int num, int index, int length)
{
    int count = 0;

    while (count < length - index)
    {
        num = num / 10;
        count++;
    }
    return (num % 10);
}

M:
Console.WriteLine("Введите пятизначное число");
int a = int.Parse(Console.ReadLine()!);
int len = LengthNumber(a);
if (len < 5) { Console.WriteLine("Это число не пятизначное"); goto M; }
int digit1 = DigitInNum(a, 1, len);
int digit2 = DigitInNum(a, 2, len);
int digit4 = DigitInNum(a, 4, len);
int digit5 = DigitInNum(a, 5, len);
if (digit1 == digit5 && digit2 == digit4) Console.WriteLine("Да, это палиндром");
else Console.WriteLine("Нет, это не палиндром");
