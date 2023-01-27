// Программа проверяет пятизначное число на палиндромом.

Console.Write("Введите  пятизначное число  - ");
int  number = Int32.Parse(Console.ReadLine());

int number1 = (number / 10000); //+
int number2 = (number / 1000);
int number3 = (number % 10000);

Console.WriteLine(number1);
Console.WriteLine(number2);
Console.WriteLine(number3);