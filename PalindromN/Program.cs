// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. 
// Через строку нельзя решать само собой.

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