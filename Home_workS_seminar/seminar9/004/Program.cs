// Написать программу вычисления функции Аккермана

Console.Write("Введите n  - ");
int n = Int32.Parse(Console.ReadLine());
Console.Write("Введите m - ");
int m = Int32.Parse(Console.ReadLine());

int Akkerman(int n , int m)
{
  if (n == 0) return m + 1;
  
  else if ((n != 0) && (m == 0)) return Akkerman(n - 1, 1);
  
  else return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.Write(Akkerman(n,m));