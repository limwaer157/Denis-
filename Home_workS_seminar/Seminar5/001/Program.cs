// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.Write("Число точки b1 - ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Число точки b2 - ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Число точки k1 - ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Число точки k2 -  ");
double k2 = double.Parse(Console.ReadLine());

void Main(double k1, double b1, double k2, double b2)
{
{
double x = (b1-b2)/(k2-k1);
double y = (k2*b1-k1*b2)/(k2-k1);
if(k1==k2) Console.Write("Заданные прямые не пересекаются!");
else
Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
}
}

Main(k1,b1,k2,b2);
