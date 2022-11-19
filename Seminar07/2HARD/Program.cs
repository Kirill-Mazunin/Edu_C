// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры), 
// причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. 
// Перемешать случайным образом элементы массива, причем чтобы каждый ГАРАНТИРОВАННО переместился на другое место 
// и выполнить это за m*n / 2 итераций. И после этого чтоб каждый уже перемещенный элемент не трогали.
// То есть если массив три на четыре, то надо выполнить не более 6 итераций. 
// И далее в конце опять вывести на экран как таблицу.


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

void Mirror(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1) / 2; j++)
        {
            int j2 = matr.GetLength(1) - j - 1;
            int t = matr[i, j];
            matr[i, j] = matr[i, j2];
            matr[i, j2] = t;
        }
    }
}


Console.Write("Введите нечетное количество строк двумерного массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите четное количество столбцов двумерного массива: ");
int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[m, n];
FillMatrix(matrix);
PrintMatrix(matrix);
Mirror(matrix);
Console.WriteLine();
PrintMatrix(matrix);