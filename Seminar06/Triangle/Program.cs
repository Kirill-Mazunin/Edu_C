//  На вход программы подаются три целых положительных числа. 
//  Определить , является ли это сторонами треугольника. 
//  Если да, то вывести всю информацию по нему - 
//  площадь, периметр, значения углов треугольника в градусах, 
//  является ли он прямоугольным, равнобедренным, равносторонним.

void Triangle()
{
    Console.WriteLine("Введите три целых положительных числа: ");
    Console.Write("Введите первое число: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите второе число: ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите третье число: ");
    double c = Convert.ToDouble(Console.ReadLine());
    if (a < b + c & b < a + b & c < b + a)
    {
        Console.WriteLine("Это треугольник");
        double p = (a + b + c) / 2;
        double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine($"его площадь: {S}");
        Console.WriteLine($"его периметр: {p * 2}");
        double A = Math.Round((180.0 / 3.14) * Math.Acos(((a * a) + (c * c) - (b * b)) / (2 * a * c)));
        Console.WriteLine($"его угол A: {A} ");
        double B = Math.Round((180.0 / 3.14) * Math.Acos(((a * a) + (b * b) - (c * c)) / (2 * a * b)));
        Console.WriteLine($"его угол B: {B} ");
        double C = Math.Round((180.0 / 3.14) * Math.Acos(((b * b) + (c * c) - (a * a)) / (2 * c * b)));
        Console.WriteLine($"его угол C: {C} ");
        if (a == b | b == c | a == c) { Console.WriteLine("Треугольник равнобедренный"); }
        if (A == 90 | B == 90 | C == 90) { Console.WriteLine("Треугольник прямоугольный"); }
        if (a == b & b == c & a == c) { Console.WriteLine("Треугольник равносторонний"); }

    }

    else { Console.WriteLine("Не треугольник"); }
}
Triangle();