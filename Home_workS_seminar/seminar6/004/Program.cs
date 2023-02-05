// Написать программу, которая обменивает элементы первой строки и последней строки



Console.Write("Введите количество строк - ");
int m = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов - ");
int n = Int32.Parse(Console.ReadLine());
Random random = new Random();

void Random(int [,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = random.Next(1,10);
        Console.Write($" {arr[i,j]}");
    }
    Console.WriteLine();
}
}
   int[,] arr = new int[m,n];
   
   Random(arr);
   
   int[,] next = new int[m,n];
   
   Console.WriteLine();

   Arrlast(arr , next);

void Arrlast(int [,] arr , int [,]next )
{
    
    for (int i = arr.GetLength(0) -1 ; i < arr.GetLength(0); i++)
    {
        for (int j =  arr.GetLength(1) - n ; j < arr.GetLength(1); j++)
        {
            next[i,j] = arr[i,j] ;
            Console.Write($" {next[i,j]}");
         
        }
        Console.WriteLine();
    }
}
 
int[,] first= new int[m,n];
Arrfirst(arr,first);
void Arrfirst(int [,] arr , int[,] first)
{
for (int i = 0; i < arr.GetLength(0) - 1; i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        first[i,j] = arr[i,j];
        Console.Write($" {first[i,j]}");
        Console.Write($" {arr[i,j]  }");
    }
     Console.WriteLine();
}
}
