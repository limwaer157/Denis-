// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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

   Arr(arr , next);

void Arr(int [,] arr , int [,]next )
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int result = arr[i,j] % 2 ;
            if (result == 0)
            {
            next[i,j] = arr[i,j] * arr[i,j];
            Console.Write($" {next[i,j]}");
            }
            else
            {
                next[i,j] = arr[i,j];
             Console.Write($" {next[i,j]}");
            }
        }
        Console.WriteLine();
    }
}