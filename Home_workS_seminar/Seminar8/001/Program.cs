// Найти произведение двух матриц

Console.Write("Введите количество строк - ");
  int a = Int32.Parse(Console.ReadLine());
  Console.Write("Введите количество столбцов - ");
  int b = Int32.Parse(Console.ReadLine());
  Random random = new Random();


void FirstMatrix(int[,] first)
{
    for (int i = 0; i < first.GetLength(0); i++)
    {
        for (int j = 0; j < first.GetLength(0); j++)
        {
            first[i,j] = new Random().Next(1,10);
            Console.Write(first[i,j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int[,] first = new int[a,b];
FirstMatrix(first);

Console.WriteLine();

void SecondMatrix(int[,] second)
{
    for (int i = 0; i < second.GetLength(0); i++)
    {
        for (int j = 0; j < second.GetLength(0); j++)
        {
            second[i,j] = new Random().Next(1,10);
            Console.Write(second[i,j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int[,] second = new int[a,b];
FirstMatrix(second);

Console.WriteLine();

void Multiplication(int[,] first , int[,] second)
{
    for (int i = 0; i < second.GetLength(0); i++)
    {
        for (int j = 0; j < second.GetLength(1); j++)
        {
             second[i,j] =  second[i,j] * first[i,j];
             Console.Write(second[i,j]);
             Console.Write(" ");
        }
        Console.WriteLine();
    }
}

Multiplication(first,second);