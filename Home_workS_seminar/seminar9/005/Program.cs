// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем


Console.Write("Введите число  - ");
int n = Int32.Parse(Console.ReadLine());
Console.Write("Введите first - ");
int first = Int32.Parse(Console.ReadLine());
Console.Write("Введите second - ");
int second = Int32.Parse(Console.ReadLine());
int temp = 0;
void PrintFibonacci(int n, int first  , int second)
{
    if (n > 0)
    {   
        Console.Write(first + second + " ");
        temp = first;
        first =second;
        second = second + temp;
        PrintFibonacci( n - 1, first, second);
    }
 
}

PrintFibonacci(n, first ,second);
