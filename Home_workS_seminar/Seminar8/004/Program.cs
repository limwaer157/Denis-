// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
    Console.Write("Enter the number of rows: ");
    int n = Int32.Parse(Console.ReadLine(()));
 
 
    for (int y = 0; y < n; y++)
{
                int number = 1;
            for (int i = 0; i < n - y; i++)
   {
           Console.Write("   ");
   }
 
            for (int x = 0; x <= y; x++)
     {
             Console.Write("    " + $"{number}" + " " );
            number = number * (y - x) / (x + 1);
     }
           Console.WriteLine();
               
} Console.WriteLine();
