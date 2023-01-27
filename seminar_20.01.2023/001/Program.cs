//  Возведите число А в натуральную степень В используя цикл

Console.Write("Введите число А - ");
int numA = Int32.Parse(Console.ReadLine());
Console.Write("В какую степень возвести число А -  ");
int numB = Int32.Parse(Console.ReadLine());
int index = 1; 
int result = 1;
while ( index <= numB)
{
  result = result * numA ;
  index = index + 1;

}
Console.WriteLine(result); 
