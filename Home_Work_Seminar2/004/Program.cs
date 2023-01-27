// Найти расстояние между точками в пространстве 2D/3D

Console.Write("Введите  необходимое пространство ");
int D = Int32.Parse(Console.ReadLine());

Console.Write("Введите  координаты по оси X для первой точки - ");
int x1 = Int32.Parse(Console.ReadLine());
Console.Write("Введите  координаты по оси  Y для первой точки - ");
int y1 = Int32.Parse(Console.ReadLine());

if ( D == 3 ) 
{
Console.Write("Введите  координаты по оси  Z для первой точки - ");
int z1 = Int32.Parse(Console.ReadLine());
}

Console.Write("Введите  координаты по оси X для второй точки - ");
int x2 = Int32.Parse(Console.ReadLine());
Console.Write("Введите  координаты по оси  Y для второй точки - ");
int y2 = Int32.Parse(Console.ReadLine());
if ( D == 3 ) 
{
Console.Write("Введите  координаты по оси  Z для второй точки - ");
int z2 = Int32.Parse(Console.ReadLine());
 int z1 = 0;
 int A = (Math.Abs(x1)-Math.Abs(x2));
 int B = (Math.Abs(y1)-Math.Abs(y2));
 int C = (Math.Abs(z1)-Math.Abs(z2));
 double result3d = Math.Sqrt((Math.Pow(Math.Abs(C),2))+(Math.Pow(Math.Abs(A),2)) + (Math.Pow(Math.Abs(B),2)));
 Console.Write("Расстояние между точками ");
 Console.WriteLine("{0:0.##}", result3d);
}

if ( D == 2 )
{
 int A = (Math.Abs(x2)-Math.Abs(x1));
 int B = (Math.Abs(y2)-Math.Abs(y1));
 double result2d = Math.Sqrt((Math.Pow(Math.Abs(A),2)) + (Math.Pow(Math.Abs(B),2)));
 Console.Write("Расстояние между точками ");
 Console.WriteLine("{0:0.##}", result2d);
}
if (D > 3)
{
Console.WriteLine("Цифра должна быть 2 или 3");
}
if (D < 2)
{
Console.WriteLine("Цифра должна быть 2 или 3");
}
