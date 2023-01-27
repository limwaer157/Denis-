// Определить, присутствует ли в заданном массиве, некоторое число
int[] array = {1,22,34,5,6,7,8,9,0,10};

void MetodRandom(int[] array, int find )
{
 int len = array.Length;
 int index = 1;
    
     if (find == array[index])
    {
        Console.WriteLine( find);
        Console.WriteLine($"{array[index]} ");
    }
    else
    {
          index = index + 1;
     }

}

MetodRandom(array , find : 5);
Console.WriteLine(string.Join("," , array ));

// void MetodFind (int[] array, int find)
// {
//  int index = 0;
//  if (array[index] == find )
//  {
//     Console.WriteLine( find);
//  }
// else 
// {
   
// }
// }
// MetodFind(array , find : 4);