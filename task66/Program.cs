// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int SumNumber(int start, int end)
{
    if (start == end) return end;
    return (start + SumNumber(start + 1, end));
}
Console.WriteLine(SumNumber(M, N));