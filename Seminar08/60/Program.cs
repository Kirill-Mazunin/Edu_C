// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] ArrayRandomUniqueNum(int x, int y, int z)
{
    int[] arr = new int[x * y * z];
    var random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        var rand = random.Next(10, 100);
        if (!(arr.Contains(rand)))
        {
            arr[i] = rand;
        }
        else
        {
            i--;
        }
    }
    return arr;
}

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

void Fill3DMatrixFromArray(int[] array, int[,,] matr)
{
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = array[count];
                count++;
            }
        }
    }
}

void Print3DMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[j, k, i]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите x размер массива: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите y размер массива: ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите z размер массива: ");
int z = int.Parse(Console.ReadLine()!);

int[] arrayForMatrix = ArrayRandomUniqueNum(x, y, z);
//PrintArray(arrayForMatrix);
Console.WriteLine();
int[,,] matrix3D = new int[x, y, z];
Fill3DMatrixFromArray(arrayForMatrix, matrix3D);
Print3DMatrix(matrix3D);
// Console.WriteLine();
// Console.WriteLine(matrix3D[1, 1, 0]);