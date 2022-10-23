// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Через строку решать нельзя.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число ");
int n = int.Parse(Console.ReadLine()!);
int temp = n;
int index = 3;
int count = 0;
int length = 0;
while (n > 0)
{
    n = n / 10;
    length++;
}
if (length < index)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (count < length - index)
    {
        temp = temp / 10;
        count++;
    }
    Console.WriteLine("Третья цифра числа " + (temp % 10));
}



