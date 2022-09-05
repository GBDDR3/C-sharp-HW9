// Задача 68: Напишите программу вычисления функции Аккермана с помощью
//  рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29


Console.WriteLine("Введите максимальное число: ");
bool numberN = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите минимальное число: ");
bool numberM = int.TryParse(Console.ReadLine(), out int m);


if (numberN == false || numberM == false)
{
    Console.WriteLine("Введены неправильные данные");
}

int FunktionAkk(int m, int n)
{
    int res = 0;
  if (m == 0) return n + 1;
  else if (n == 0) return FunktionAkk(m - 1, 1);
  else
  { 
   res = FunktionAkk(m - 1, FunktionAkk(m, n - 1));
   return res;
  }
}
int result = FunktionAkk(m, n);
Console.WriteLine(result);
