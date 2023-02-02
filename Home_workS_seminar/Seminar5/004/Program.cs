// Написать программу копирования массива
Console.Write("Введите длинну массива - ");
int m = Int32.Parse(Console.ReadLine());

void ArrayFill(int[] num)
{
 for (int i = 0; i < num.Length; i++)
 {
    num[i] = new Random().Next(1,20);
 }

}
int[] num = new int[m]; 
ArrayFill(num);
Console.WriteLine(string.Join("," , num ));

void CopyArray(int[] num , int [] arr )
{
    for (int i = 0; i < num.Length; i++)
    {
        arr[i] = num[i];
    }
} 
int[] arr = new int[m];
CopyArray(num,arr);
Console.WriteLine(string.Join("," , arr ));