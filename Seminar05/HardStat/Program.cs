// Задайте массив случайных целых чисел.
//  Найдите максимальный элемент и его индекс, 
//  минимальный элемент и его индекс, 
//  среднее арифметическое всех элементов. 
//  Сохранить эту инфу в отдельный массив 
//  и вывести на экран с пояснениями. 
//  Найти медианное значение первоначалального массива, 
//  возможно придется кое-что для этого дополнительно выполнить.


void FillArray(int[] array)
{
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 100);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void PrintArrayObject(object[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
}

int MaxElementInArray(int[] array)
{
    int max = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) { max = array[i]; index = i; }
    }
    return max;
}
int MinElementInArray(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) { min = array[i]; }
    }
    return min;
}
int MaxElementIndex(int[] array, int find)
{
    int max = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) { max = array[i]; index = i; }
    }
    return index;
}
int MinElementIndex(int[] array, int find)
{
    int min = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) { min = array[i]; index = i; }
    }
    return index;
}
double AverageElementArray(int[] array)
{
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    double result = (double)sum / array.Length;

    return result;
}
double MedianElementInArray(int [] array)
{
var n = array.Length;
double median;
if (n % 2 != 0) { median = array[(n + 1) / 2 - 1];}
else { median = (array[n / 2 - 1] + array[n / 2]) / 2.0d; }
return median;
}



int[] array = new int[5];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int min = MinElementInArray(array);
int max = MaxElementInArray(array);

object[] array2 = new object[5];
array2[0] = MinElementInArray(array) + " это минимальный элемент массива";
array2[1] = MinElementIndex(array, min) + " это индекс минимального элемента массива";
array2[2] = MaxElementInArray(array) + " это максимальный элемент массива";
array2[3] = MaxElementIndex(array, max) + " это индекс максимального элемента массива";
array2[4] = AverageElementArray(array) + " это среднее арифметическое элементов массива";

PrintArrayObject(array2);

Console.WriteLine(MedianElementInArray(array)+ " это медианное значение массива");