// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4



void FindElementIndex(int[,] arr)
{
    Console.Write("Введите значение искомого элемента: ");
    int find = int.Parse(Console.ReadLine()!);
    int indexrow = 0;
    int indexcol = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == find)
            {
                indexrow = i; indexcol = j;
            }

        }
    }
    if (arr[indexrow, indexcol] != find)
    {
        Console.WriteLine("Такого значения нет");
    }
    else
    {
        Console.WriteLine($"Индекс искомого элемента: [{indexrow},{indexcol}]");
    }
}

int[,] array = new int[,]
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
};

FindElementIndex(array);