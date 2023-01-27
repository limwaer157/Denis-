// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void PrintArray(int[] array)
{
    int len = array.Length;
    int index = 0;
    while (index < len)
    {
        array [index] = new Random().Next(0,1);
        index = index + 1 ;
    }
}
int[] array = new int[8];
PrintArray(array);
Console.WriteLine(string.Join("," , array ));
