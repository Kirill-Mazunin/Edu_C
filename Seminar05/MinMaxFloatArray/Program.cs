// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void FillArray(float[] array)
{
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 100);
    }
}
void PrintArray(float[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
float MaxElementInArray(float[] array)
{
    float max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) { max = array[i]; }
    }
    return max;
}
float MinElementInArray(float[] array)
{
    float min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) { min = array[i]; }
    }
    return min;
}

float[] array = new float[5];

FillArray(array);
PrintArray(array);

float min = MinElementInArray(array);
float max = MaxElementInArray(array);
Console.WriteLine();
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine("Разница между минимальным и максимальным элементом массива: " + (max - min));