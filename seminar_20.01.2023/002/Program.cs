// найти сумму чисел от 1 до А
Console.Write("Введите число до которого нужно найти сумму всех чисел -  ");
int numA = Int32.Parse(Console.ReadLine());
int index = 0; 
int result = 0;
while ( index < numA)
{
  result = result + index ;
  index = index + 1;
}
Console.WriteLine(result); 
