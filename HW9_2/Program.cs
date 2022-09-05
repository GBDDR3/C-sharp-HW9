//  Задайте значения M и N. Напишите программу, которая 
//  найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите максимальное число: ");
bool numberN = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите минимальное число: ");
bool numberM = int.TryParse(Console.ReadLine(), out int m);


if (numberN == false || numberM == false)
{
    Console.WriteLine("Введены неправильные данные");
}
if (m > n) Console.WriteLine("Введены неправильные данные");

int Factorial(int m, int n)
{
    int f = 0;
    if (n == m) return n;
    else
    {
        f = Factorial(m, n - 1) + n;
        return f;
    }
}
int result = Factorial(m, n);
Console.WriteLine(result);
