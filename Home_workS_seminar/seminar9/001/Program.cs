// Показать натуральные числа от N до 1, N задано



Console.Write("Введите число А - ");
int a = Int32.Parse(Console.ReadLine());

string NumberLine(int a)
{
   if(a > 0) return $" {a}" +  NumberLine( a - 1 );
    else return string.Empty;
}

Console.Write(NumberLine(a ));