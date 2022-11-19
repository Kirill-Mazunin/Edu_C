// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

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

void SelectionSortMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(0); k++)
            {
                for (int l = 0; l < matr.GetLength(1); l++)
                {
                    if (matr[k, l] > matr[i, j])
                    {
                        int temp = matr[k, l];
                        matr[k, l] = matr[i, j];
                        matr[i, j] = temp;
                    }
                }
            }
        }
    }
}

Console.Write("Введите количество строк двумерного массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов двумерного массива: ");
int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[m, n];
FillMatrix(matrix);
PrintMatrix(matrix);
SelectionSortMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);