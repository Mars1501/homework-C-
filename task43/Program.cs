// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение b1");
double numB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double numK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double numB2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double numK2 = Convert.ToInt32(Console.ReadLine());


double x = -(numB1 - numB2) / (numK1 - numK2);
double y = numK1 * x + numB1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");
