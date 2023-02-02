// Задать двумерный массив следующим правилом: Aₘₙ = m+n

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

int[,] sumArr = new int[m,n];
Random(arr);
  Console.WriteLine();
  Console.WriteLine();
sumArray(arr, sumArr);

void sumArray(int[,] arr , int[,] sumArr)
{
   
    for (int i = 0; i < sumArr.GetLength(0); i++)
    {

        for (int j = 0; j < sumArr.GetLength(1); j++)
        {
           sumArr [i,j] = sumArr[i,j] + j + i +1;
           Console.Write($" {sumArr[i,j]}");
        }
        
         Console.WriteLine();
    }
}