// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillMatrix(int[,] matr)
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
void PrintMatrix(int[,] matr)
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

int[] MatrixRowSumToArray(int[,] matr)
{
    int[] arrayRowSum = new int[matr.GetLength(0)];
    int index = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }
        arrayRowSum[index] = sum;
        index++;
    }
    return arrayRowSum;
}
int MinElementIndex(int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) { min = array[i]; index = i; }
    }
    return index;
}

int[,] matrix = new int[4, 4];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Строка {MinElementIndex(MatrixRowSumToArray(matrix))+1} с минимальной суммой элементов");
