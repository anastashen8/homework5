// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write ("Введите координаты x первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты x второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());


int sum = ((x2 - x1)*(x2 - x1)) + ((y2 - y1)*(y2 - y1)) + ((z2 - z1)*(z2 - z1));
double distance = Math.Round(Math.Sqrt(sum),2);

Console.WriteLine($"Расстояние между точка = {distance}");