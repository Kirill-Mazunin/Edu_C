// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.. 
// Далее надо посчитать количество нулей и единиц, 
// если единиц больше чем нулей то вывести TRUE на экран, 
// иначе вывести False.

void Array01()
{
    int[] array = new int[8];
    var random = new Random();
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 2);
        Console.Write($"{array[i]} ");
        if (array[i] > 0) { count += array[i]; }
    }
    Console.WriteLine();
    if (count > array.Length / 2) { Console.WriteLine("TRUE"); }
    else { Console.WriteLine("False"); }
}
Array01();
