// Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива.


// Console.Write("Введите количество строк - ");
//   int m = Int32.Parse(Console.ReadLine());
//   Console.Write("Введите количество столбцов - ");
//   int n = Int32.Parse(Console.ReadLine());
//   Random random = new Random();

//   void Random(int [,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
// {
//         for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i,j] = random.Next(1,10);
//         Console.Write($" {arr[i,j]}");
//     }
//     Console.WriteLine();
// }
// }
//    int[,] arr = new int[m,n];
//    Random(arr);
//    int var = 0;
//    void SortArr(int[,] arr)
//    {
//     int[] sumArr = new int[arr.GetLength(1)];

//      for (int i = 0; i < arr.GetLength(0); i++)
//   {
//      for (int j = 0; j < arr.GetLength(1)  -1 ; j++)
//     {
//       for (int n = 0; n < arr.GetLength(0) ; n++)
//       {
//         for (int m = 0; m < arr.GetLength(1); m++)
//         {
//           if (arr[i,j] < arr[i,j + 1 ] )
//       {
//         var = arr[i,j];
//         arr[i,j] = arr[i ,j +1];
//         arr[i,j+1] = var;
//       }
//         }
         
//       }
     
      
//     }   
//   }
// }
// SortArr(arr);

// Console.WriteLine();

// Console.WriteLine();
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//   for (int j = 0; j < arr.GetLength(1); j++)
//   {
//     Console.Write($" {arr[i,j]}");
//   }
//   Console.WriteLine();
// }

// int[] sumArr = Summ(arr);
// int min = sumArr[0];
// for (int i = 0; i < m; i++)
// {
//     Console.WriteLine($"Сумма {i +1}  строчки  =  {sumArr[i]}");
// }


// int a = 0;
// for (int i = 0; i < sumArr.Length; i++)
// {
    
//     if (sumArr[i] < min) 
//     {
//     min = sumArr[i];
//     a = i;
//     }
// }

// Console.WriteLine($" Наименьшая сумма чисел  = {min}  которая находится в строчке № {a + 1}");


// Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива.

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
   
   Random(arr);

int[] sumAr = new int[n];


for (int i = 0; i < arr.GetLength(0); i++)
{
  
  for (int j = 0; j <arr.GetLongLength(1); j++)
  {
   
    Summ(arr);
    sumAr = Summ(arr);
    Console.WriteLine(string.Join("," , sumAr));
  }
  // Console.WriteLine(string.Join("," , sumAr));
}


  //  Summ(arr);
   
   
  //  int[] sumAr = Summ(arr);

   int[] Summ(int[,] arr)
   {
//     for (int k = 0; k < arr.GetLength(0); k++)
// {
//      for (int j = 0; j < arr.GetLength(1); j++)
           
//     {
//         sumAr[j] = arr[k,j] ;
//     }
    {
   for (int i = 0; i < sumAr.Length; i++)
            {
             
                for (int j = 0; j < sumAr.Length - 1; j++)
                {
                    if (sumAr[j] < sumAr[j + 1])
                    {
                        int var = sumAr[j];
                        sumAr[j]= sumAr[j + 1];
                        sumAr[j + 1] = var;
                       
                    }
                   
                }
                
                  
                
                
            }
    }  
     return sumAr;
    
}
  
 


// Console.WriteLine(string.Join("," , sumAr));

// void Print(int [] sumAr )
// {
//    for (int i = 0; i < sumAr.Length; i++)
//             {
//                 for (int j = 0; j < sumAr.Length - 1; j++)
//                 {
//                     if (sumAr[j] < sumAr[j + 1])
//                     {
//                         int var = sumAr[j];
//                         sumAr[j]= sumAr[j + 1];
//                         sumAr[j + 1] = var;

//                     }
                    
//                 }
//             }
            
// }

// for (int i = 0; i < m; i++)
// {
//   Print(sumAr);
//   Console.WriteLine(string.Join("," , sumAr));
// }


//Console.WriteLine(string.Join("," , sumAr));



// int min = sumArr[0];
// for (int i = 0; i < m; i++)
// {
//     Console.WriteLine($"Сумма {i +1}  строчки  =  {sumArr[i]}");
// }


// int a = 0;
// for (int i = 0; i < sumArr.Length; i++)
// {
    
//     if (sumArr[i] < min) 
//     {
//     min = sumArr[i];
//     a = i;
//     }
// }

// Console.WriteLine($" Наименьшая сумма чисел  = {min}  которая находится в строчке № {a + 1}");
