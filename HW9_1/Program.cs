// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""


Console.WriteLine("Введите число n: ");
bool numberN = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите число m : ");
bool numberM = int.TryParse(Console.ReadLine(), out int m);


if (numberN == false || numberM == false)
{
    Console.WriteLine("Введены неправильные данные");
}

string S = String.Empty;

string FillString(string c, int n, int m)
{
    c = $"{Convert.ToString(n)}";
    if (n == m) return c;
    else
    {
        c = FillString(c, n - 1, m) + c;
        return c;
    }
}
string result = FillString(S, n, m);
Console.WriteLine(result);