
int reverse(int num, int cont)
{
    while (num > 0) 
    { 
        cont = cont * 10 + num % 10; 
        num /= 10; 
    }
    return cont;
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
int cont = reverse(num, 0);
if (cont == num) Console.Write("Введенное число - палиндром");
else Console.Write("Введенное число не является палиндромом");