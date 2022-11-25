// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// cij = ai1 * b1j + b1j + ai2 * b 2j + ... + aip * bpj

int[,] ProductMatrix(int[,] A, int[,] B)
{
    int[,] resMatrix = new int[A.GetLength(0), B.GetLength(1)];
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            for (int k = 0; k < B.GetLength(0); k++)
            {
                resMatrix[i, j] += A[i, k] * B[k, j];
            }
        }
    }
    return resMatrix;
}
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

int[,] matrixA = new int[2, 2];
int[,] matrixB = new int[2, 2];

FillMatrix(matrixA);
PrintMatrix(matrixA);
Console.WriteLine();
FillMatrix(matrixB);
PrintMatrix(matrixB);
int[,] resultMatrix = ProductMatrix(matrixA, matrixB);
Console.WriteLine();
PrintMatrix(resultMatrix);