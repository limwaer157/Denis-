// Найти сумму элементов от M до N, N и M заданы

Console.Write("Введите число А - ");
int a = Int32.Parse(Console.ReadLine());
Console.Write("Введите число B - ");
int b = Int32.Parse(Console.ReadLine());

int Summ(int a ,int b)
{
    if (b < a) return 0;    
    else return  a  + Summ(a + 1 , b);
}

int result = Summ(a,b);

Console.WriteLine(result);