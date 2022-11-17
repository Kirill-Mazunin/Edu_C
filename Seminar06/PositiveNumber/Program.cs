//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array; 
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void PositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) {count++;}
    }
    Console.WriteLine();
    Console.WriteLine($"Вы ввели {count} числа больше ноля");
}

Console.Write("Сколько чисел будет введено? ");
int M = int.Parse(Console.ReadLine()!);
int[] array = new int[M];

FillArray(array);
PrintArray(array);
PositiveNumber(array);
