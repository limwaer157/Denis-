// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.



Console.Write("Введите количество строк - ");
int m = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов - ");
int n = Int32.Parse(Console.ReadLine());
Random random = new Random();

void Random(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(1, 10);
            Console.Write($" {arr[i, j]}");
        }
        Console.WriteLine();
    }
}
int[,] arr = new int[m, n];
Random(arr);
int[] Summ(int[,] arr)
{
    int[] sumArr = new int[arr.GetLength(0)];

    for (int j = 0; j < arr.GetLength(1); j++)
    {

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sumArr[i] = arr[i, j] + sumArr[i];
        }

    }
    return sumArr;
}

int[] sumArr = Summ(arr);
int min = sumArr[0];
for (int i = 0; i < m; i++)
{
    Console.WriteLine($"Сумма {i + 1}  строчки  =  {sumArr[i]}");
}


int a = 0;
for (int i = 0; i < m; i++)
{

    if (sumArr[i] < min)
    {
        min = sumArr[i];
        a = i;
    }
}

Console.WriteLine($"Наименьшая сумма чисел  = {min}  которая находится в строчке № {a + 1}");

Console.WriteLine();

int[] SummColumns(int[,] arr)
{
    int[] sumArrColumns = new int[n];

    for (int j = 0; j < arr.GetLength(0); j++)
    {

        for (int i = 0; i < arr.GetLength(1); i++)
        {
            sumArrColumns[j] = arr[i, j] + sumArrColumns[j];

        }

    }
    return sumArrColumns;
}

int[] sumArrColumns = SummColumns(arr);
int mincolumns = sumArrColumns[0];
for (int i = 0; i < m; i++)
{
    Console.WriteLine($"Сумма {i + 1}  столбца  =  {sumArrColumns[i]}");
}

int b = 0;
for (int i = 0; i < n; i++)
{
    if (sumArrColumns[i] < mincolumns)
    {
        mincolumns = sumArrColumns[i];
        b = i;
    }
}

Console.WriteLine($"Наименьшая сумма чисел  = {mincolumns}  которая находится в столбце № {b + 1}");
Console.WriteLine();

void Prit(int[,] arr)
{
    for (int i = 0; i < m; i++)
    {


        for (int j = 0; j < n; j++)
        {
            if (i == a || j == b) arr[i, j] = 0;
            Console.Write($" {arr[i, j]}");
        }
        Console.WriteLine();
    }
}
Prit(arr);
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (arr[i, j] > 0)
            Console.Write($" {arr[i, j]}");
    }
    Console.WriteLine();
}