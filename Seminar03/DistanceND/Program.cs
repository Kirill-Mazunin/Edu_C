// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

Double DistanceND(int N)
{
int count = 0;
double cont = 0;
while (count < N)
{
    Console.Write("Введите координату " + (count + 1) + " первой точки: ");
    int x1 = int.Parse(Console.ReadLine()!);
    Console.Write("Введите координату " + (count + 1) + " второй точки: ");
    int x2 = int.Parse(Console.ReadLine()!);
    cont = cont + (Math.Pow((x2 - x1), 2));
    count += 1;
}
return(Math.Round(Math.Sqrt(cont), 2)); 
}

Console.Write("Введите размерность пространства: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write(DistanceND(N));