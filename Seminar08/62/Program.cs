// Задача 62. Напишите программу, 
// которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}

void FillSnailMatrix(int[,] matr)
{
    int num = 1;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = i; j < matr.GetLength(0) - i; j++)
        {
            matr[i, j] = num++;
        }
        for (int k = i + 1; k < matr.GetLength(1) - i; k++)
        {
            matr[k, matr.GetLength(1) - 1 - i] = num++;
        }
        for (int j = matr.GetLength(0) - i - 2; j >= i; j--)
        {
            matr[matr.GetLength(1) - 1 - i, j] = num++;
        }
        for (int k = matr.GetLength(1) - 2 - i; k > i; k--)
        {
            matr[k, i] = num++;
        }
    }
}

int[,] matrix = new int[4, 4];

FillSnailMatrix(matrix);
PrintMatrix(matrix);