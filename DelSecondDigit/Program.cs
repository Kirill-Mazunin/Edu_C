Console.Write("Введите число ");
int n = int.Parse(Console.ReadLine()!);
int index = 2;
int temp = n;
int res = 0;
int step = 1;
int count = 1;
int length = 0;

while (n > 0)
{
    n = n / 10;
    length++;
}

while (temp != 0)
{
    if (count != length - index + 1)
    {
        res = res + ((temp % 10) * step);
        step = step * 10;
    }
    temp = temp / 10;
    count++;
}

Console.WriteLine(res);
