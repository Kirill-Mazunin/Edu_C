// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры).
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, 
// найти максимальное число и его индекс, среднее арифметическое. Вывести эту информацию на экран.


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
void MinElementInArray(int[,] matr)
{
    int min = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min) { min = matr[i, j]; }
        }
    }
    Console.WriteLine($"Минимальный элемент массива: {min}");
}
void MinElementIndex(int[,] matr)
{
    int min = matr[0, 0];
    int indexrow = 0;
    int indexcol = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min) { min = matr[i, j]; indexrow = i; indexcol = j; }
        }
    }
    Console.WriteLine($"Индекс минимального элемента: [{indexrow},{indexcol}]"); 
}
void MaxElementInArray(int[,] matr)
{
    int max = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] > max) { max = matr[i, j]; }
        }
    }
    Console.WriteLine($"Максимальный элемент массива: {max}");
}
void MaxElementIndex(int[,] matr)
{
    int max = matr[0, 0];
    int indexrow = 0;
    int indexcol = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] > max) { max = matr[i, j]; indexrow = i; indexcol = j; }
        }
    }
    Console.WriteLine($"Индекс максимального элемента: [{indexrow},{indexcol}]"); 
}
void AvrElementInArray(int[,] matr)
{
    double sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i,j];
        }
    }
    double result = Math.Round((double)sum / (matr.GetLength(0) * matr.GetLength(1)),2) ;
    Console.WriteLine($"Среднее арифметическое элементов массива: {result}");
}

int[,] matrix = new int[3, 4];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
MinElementInArray(matrix);
MinElementIndex(matrix);
MaxElementInArray(matrix);
MaxElementIndex(matrix);
AvrElementInArray(matrix);