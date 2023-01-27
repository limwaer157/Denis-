// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.Write("Введите  число X - ");
int X = Int32.Parse(Console.ReadLine());
Console.Write("Введите  число Y - ");
int Y = Int32.Parse(Console.ReadLine());

if ( X > 0 && Y > 0 ) 
{
Console.WriteLine("Точка находится в 1 четверти");
}
if (X < 0 && Y < 0 ) 
{
Console.WriteLine("Точка находится в 3 четверти");
}
if (X < 0 && Y > 0 ) 
{
Console.WriteLine("Точка находится в 2 четверти");
}
if (X > 0 && Y < 0 ) 
{
Console.WriteLine("Точка находится в 4 четверти");
}
