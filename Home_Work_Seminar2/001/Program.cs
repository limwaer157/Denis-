// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Write("Введите номер дня недели  - ");
int numberA = Int32.Parse(Console.ReadLine());

  if(numberA == 1   || numberA == 2 || numberA == 3 || numberA == 4 || numberA == 5)
   {
     Console.WriteLine("Увы, сегодня на работу");
    } 

 if(numberA == 6 )
     {
     Console.WriteLine(" Выходной день!");
     } 
 if(numberA == 7 )
     {
     Console.WriteLine(" Выходной день!");
     } 
  if (numberA > 7 )
     {
     Console.WriteLine(" Такого дня недели не существует");
     } 
  