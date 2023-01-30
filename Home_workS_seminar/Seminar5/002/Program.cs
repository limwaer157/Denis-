// Показать числа Фибоначчи

double Fibonacci(int n)
{
 if(n == 1 || n == 2) return 1;
 else return Fibonacci(n-1) + Fibonacci(n-2);
}


Console.Write("Число - ");
int num = Int32.Parse(Console.ReadLine()) + 1;
for (int i = 1; i < num; i++)
{
  Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}