// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента


Console.Write("Введите количество по оси х - ");
  int a = Int32.Parse(Console.ReadLine());
  Console.Write("Введите количество о оси у - ");
  int b = Int32.Parse(Console.ReadLine());
  Random random = new Random();
 Console.Write("Введите количество о оси z - ");
   int c = Int32.Parse(Console.ReadLine());
  

void FirstMatrix(int[,,] first)
{
    int n = 10;
    for (int i = 0; i < first.GetLength(0); i++)
    {
        
        for (int j = 0; j < first.GetLength(1); j++)
        {
            
            for (int k = 0; k < first.GetLength(2); k++)
            {
                  
                
                   first[i,j,k] = n + 1 ;
                   Console.Write(first[i,j,k] + $"(x-{i} y-{j} z-{k})");
                   Console.Write(" ");
                   n = n+ 1;
            }
         Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] first = new int[a,b,c];
FirstMatrix(first);
