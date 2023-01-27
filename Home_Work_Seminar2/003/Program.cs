// Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Введите  четверть координат - ");
int number = Int32.Parse(Console.ReadLine());

if (number == 1 ) 
{
Console.WriteLine(" X ( 1 ; infinity) ; Y( 1 ; infinity ) ");
}
if (number == 2 ) 
{
Console.WriteLine(" X ( -1 ; -infinity) ; Y( 1 ; infinity ) ");
}
if (number == 3 ) 
{
Console.WriteLine(" X ( -1 ; -infinity) ; Y( -1 ; -infinity ) ");
}
if (number == 4 ) 
{
Console.WriteLine(" X ( 1 ; infinity) ; Y( -1 ; -infinity ) ");
}
if (number > 4 ) 
{
Console.WriteLine("Цифра должна быть от 1 до 4 ");
}
