//   Составить частотный словарь элементов двумерного массива


Console.Write("Введите число строк - ");
int n = Int32.Parse(Console.ReadLine());
Console.Write("Введите число столбцов - ");
int m = Int32.Parse(Console.ReadLine());
int[] second = new int [n*m];
void ArrayFullRandom(int[,] massiv)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            massiv[i,j] = new Random().Next(1,10);
            Console.Write(massiv[i,j]);
            Console.Write(" ");
        }
         Console.WriteLine();
    }
}

void NewMassiv(int[,] massiv , int[] second)
{
    int k = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        second[k] = massiv[i,j];
        k++;
    }
}
}

void SortMassiv(int [] second)
{
    int var =0;
for (int j = 0; j < n*m; j++)
{
    
   for (int i = 0; i < (n*m) - 1 ; i++)
{
        if (second[i] > second[i +1] )
        {
           var = second[i];
           second[i] = second[i +1];
           second[i +1] = var;
        }   
}
}
}

int[,] massiv = new int[n,m];
ArrayFullRandom(massiv);
NewMassiv(massiv,second);

Console.WriteLine();
Console.Write(string.Join( " , " , second));

Console.WriteLine();

SortMassiv(second);
Console.WriteLine();
Console.Write(string.Join( " , " , second));


Console.WriteLine();

void Analiz(int[] second)
{
   
 for (int i = 1; i < 10; i++)
 {
    int result =0;
    for (int j = 0; j < m*n; j++)
    {
        if (second[j] == i)  result++;

    }
            if (result != 0)
         {
          double procent = result * 100/massiv.Length;
           Console.WriteLine($"Число {i} встречается {result} раз. Частота в массиве {procent} % ");
          }
          
    }
 }


Console.WriteLine();

Analiz(second);