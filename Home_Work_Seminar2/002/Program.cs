// По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите первое число - ");
int number1 = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
int number2 = Int32.Parse(Console.ReadLine());
int numberC = (number1 * number1);
int numberD = (number2 * number2);
if(numberC == number2)
   {
     Console.Write(" Число - ");
     Console.Write(number1);
     Console.WriteLine(" является квадратом второго ");
    } 
else if (numberD == number1)
   {
     Console.Write(" Число -  ");
     Console.Write(number2);
     Console.WriteLine(" является квадратом первого ");
   }
else 
   {
     Console.WriteLine(" Числа не являются кватратами друг друга ");
   }