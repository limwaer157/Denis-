// Написать программу, которая обменивает элементы первой строки и последней строки
Console.WriteLine("Hello, World!");


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
int[,] arrayNew = new int[1,columns];
int rows2 = rows;
Random(array1);


void FirstGangeArray(int[,] array1  , int [,] arrayNew)
{
   
    
for (int rows = 0; rows < array1.GetLength(0); rows++)
{
    for (int columns = 0; columns < array1.GetLength(1); columns++)
    {     
         
            if (rows ==  0 )
        {
           arrayNew[0,columns] = array1[rows,columns];
           if( columns == array1.GetLength(1) )
           rows = array1.GetLength(0) +1;
        }   
        
    }    
}
}

FirstGangeArray(array1 ,arrayNew);

 int[,] secondArray = new int [1,columns];

void SecondGangeArray(int[,] array1  )
{
   
for (int rows = 0; rows < array1.GetLength(0); rows++)
{
    for (int columns = 0; columns < array1.GetLength(1); columns++)
    {     
         
            if (rows ==  array1.GetLength(0) -1 )
        {
           secondArray[0,columns] = array1[rows,columns];
           if( columns == array1.GetLength(1) )
           rows = array1.GetLength(0) +1;
        }   
        
    }    
}
}
SecondGangeArray(array1);

Console.WriteLine();
 for (int j = 0; j < secondArray.GetLength(1); j++)
    {
      Console.Write(secondArray[0,j])  ;
      Console.Write(" ");
    }

Console.WriteLine();
for (int i = 1; i < array1.GetLength(0) -1; i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        Console.Write(array1[i,j]);
        Console.Write(" ");
           }
    Console.WriteLine();
}
    for (int j = 0; j < arrayNew.GetLength(1); j++)
    {
      Console.Write(arrayNew[0,j])  ;
      Console.Write(" ");
    }
Console.WriteLine();
