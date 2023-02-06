// Показать двумерный массив размером m×n заполненный вещественными числами
Console.Write("Введите количество строк - ");
int m = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов - ");
int n = Int32.Parse(Console.ReadLine());
Random random = new Random();
void Random(double [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
     for (int j = 0; j < arr.GetLength(1); j++)
     {
        arr[i,j] = random.Next(1,10) + random.NextDouble();
        Console.Write($" {arr [i,j] } ");
     }
     Console.WriteLine();
    }

}
double[,] arr = new double [m,n];
Random(arr);
