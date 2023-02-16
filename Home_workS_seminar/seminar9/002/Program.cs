// Показать натуральные числа от M до N, N и M заданы

Console.Write("Введите число А - ");
int a = Int32.Parse(Console.ReadLine());
Console.Write("Введите число B - ");
int b = Int32.Parse(Console.ReadLine());


string PrintNum(int a , int b)
{
    if(a <=  b) return $" {a}" + PrintNum(a + 1 , b);
    else return string.Empty;
}

Console.Write(PrintNum(a ,b));