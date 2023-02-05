// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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
            array1[rows,columns] = new Random().Next(1,10);
            Console.Write(array1 [rows ,columns]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int[,] array1 = new int[rows,columns];
int[,] arrayNew = new int[rows,columns];

Random(array1);

void SortArray(int[,] array1 )
{
    int var =0;
    for (int i = 0; i < array1.GetLength(1); i++)
    {
for (int rows = 0; rows < array1.GetLength(0); rows++)
{
    for (int columns = 0; columns < array1.GetLength(1)-1; columns++)
    {     
         
            if (array1[rows,columns] < array1[rows,columns + 1 ] )
        {
           var = array1[rows,columns];
           array1[rows,columns] = array1[rows,columns + 1 ];
           array1[rows,columns + 1 ] = var;
        }   
    }    
}
}
}
SortArray(array1); 

Console.WriteLine();

for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        Console.Write(array1[i,j]);
                Console.Write(" ");

    }
    Console.WriteLine();
}