// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели ");
int WeekNum = int.Parse(Console.ReadLine()!);
if(WeekNum == 1 || WeekNum == 2 || WeekNum == 3 || WeekNum == 4 || WeekNum == 5)
{
    Console.WriteLine("Это будний день");
}
else if(WeekNum == 6 || WeekNum == 7)
{
    Console.WriteLine("Это выходной!");
}
else 
{
    Console.WriteLine("В неделе всего семь дней");
}

 