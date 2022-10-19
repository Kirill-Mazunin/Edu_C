// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Через строку решать нельзя.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число ");
int n = int.Parse(Console.ReadLine()!);
int b = n;
int count = 0;
int length = 0;
while(n > 0)
{
    n = n/10;
    length++;
}
int c = length;
if (c < 3)
{
    Console.WriteLine("Третьей цифры нет");
    //break;
}
else
{
    while(count < c - 3)
    {
        b = b/10;
        count++;
    }
   
    
Console.WriteLine(b%10);
}



