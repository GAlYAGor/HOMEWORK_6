// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("введите значение b1: ");
double b1 = int.Parse(Console.ReadLine());

Console.Write("введите значение a1: ");
double a1 = int.Parse(Console.ReadLine());
Console.Write("введите значение b2: ");
double b2 = int.Parse(Console.ReadLine());
Console.Write("введите значение a2: ");
double a2 = int.Parse(Console.ReadLine());

double x = (-b2 + b1) / (-a1 + a2);
double y = a2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");