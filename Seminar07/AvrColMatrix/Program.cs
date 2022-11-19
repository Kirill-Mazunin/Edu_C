// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] matr)
{
    var random = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = random.Next(1, 10);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void AvrColumn(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            sum += matr[j, i];
        }
        Console.WriteLine($"Среднее арифметическое {i} столбца: {(Math.Round(sum / matr.GetLength(0), 1))}");
    }
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
AvrColumn(matrix);

