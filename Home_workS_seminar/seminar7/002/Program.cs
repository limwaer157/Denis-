// Написать программу, которая в двумерном массиве заменяет строки на столбцы
//  или сообщить, что это невозможно (в случае, если матрица не квадратная).

Console.Write("Введите количество строк - ");
int rows = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов - ");
int columns = Int32.Parse(Console.ReadLine());
void Random(int[,] array1)
{
    for (int rows = 0; rows < array1.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array1.GetLength(1); columns++)
        {
            array1[rows, columns] = new Random().Next(1, 10);
            Console.Write(array1[rows, columns]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int[,] array1 = new int[rows, columns];
int[,] arrayNew = new int[rows, columns];
if (rows == columns)
{
    Random(array1);

    void GangeArray(int[,] array1, int[,] arrayNew)
    {
        int probel = 0;
        int k = 0;
        for (int columns = 0; columns < array1.GetLength(0); columns++)
        {
            for (int rows = 0; rows < array1.GetLength(1); rows++)
            {
                arrayNew[rows, columns] = array1[rows, k];


            }
            k++;


        }
    }
    GangeArray(array1, arrayNew);

    Console.WriteLine();
    Console.WriteLine();


    for (int i = 0; i < arrayNew.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNew.GetLength(0); j++)
        {

            Console.Write(arrayNew[j, i]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
else Console.WriteLine("Матрица не квадратная");
