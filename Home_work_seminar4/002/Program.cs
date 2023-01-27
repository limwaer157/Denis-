// Определить, присутствует ли в заданном массиве, некоторое число
int[] array = {1,22,34,5,6,7,8,9,0,10};

void MetodRandom(int[] array, int find )
{
    int num = 0;
 int len = array.Length;
 for (int index = 0; index < len; index = index + 1 )
 {
    if (array[index] == find )
    Console.WriteLine("Число "+ $"{ find}" + " есть в массиве"   );
 
   

 }

}
MetodRandom(array,find : 1 );