// Написать программу масштабирования фигуры

Console.Clear();
Console.SetCursorPosition(15, 1);
Console.WriteLine("-");

Console.Write("Координаты х первой точки фигуры - ");
int x = int.Parse(Console.ReadLine());
Console.Write("Координаты у второй точки фигуры - ");
int y = int.Parse(Console.ReadLine());
Console.Write("Координаты х второй точки фигуры - ");
int b = int.Parse(Console.ReadLine());
Console.Write("Координаты у второй точки фигуры - ");
int c = int.Parse(Console.ReadLine());
Console.Write("Координаты х третьей точки фигуры - ");
int d = int.Parse(Console.ReadLine());
Console.Write("Координаты у третьей точки фигуры - ");
int e = int.Parse(Console.ReadLine());
Console.Write("Координаты х четвертой точки фигуры - ");
int f = int.Parse(Console.ReadLine());
Console.Write("Координаты у четвертой точки фигуры - ");
int g = int.Parse(Console.ReadLine());

// int xa = 1;
// int ya = 1;
// int xb = 1;
// int yb = 50;
// int xc = 100;
// int yc = 50;

Console.SetCursorPosition(x ,y);
Console.WriteLine("+");
Console.SetCursorPosition(b,c);
Console.WriteLine("+");
Console.SetCursorPosition(d , e);
Console.WriteLine("+");
Console.SetCursorPosition(f ,g );
Console.WriteLine("+");

// int x = xa;
// int y = xb;
// int count = 0;


// while(count < 10000)
// {
//   {
//     int what = new Random().Next(0, 3);
//     if(what  == 0)
//     {
//         x = (x + xa) / 2;
//         y = (y + ya) / 2;
//     }
//     if (what == 1) 
//     {
//     x = (x + xb) / 2;
//     y = (y + yb) / 2;
//     }
//     if(what == 2){
//     x = (x + xc) / 2;
//     y = (y + yc) / 2;}
//    }
//     Console.SetCursorPosition(x, y);
//     Console.WriteLine("+");
//     count = count + 1;
// }