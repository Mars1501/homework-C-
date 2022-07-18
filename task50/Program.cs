// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите М и N");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите i0 и j0");
int i0 = Convert.ToInt32(Console.ReadLine());
int j0 = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[M, N];
Random rnd = new Random();
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        array[i, j] = rnd.Next(-10, 10);
        Console.Write(array[i, j] + " ");
    }


    Console.WriteLine();
}

if (i0 >= M || j0 >= N || i0 < 0 || j0 < 0)
{
    Console.WriteLine("Error");
}
else
{
    Console.WriteLine("Element with i = i0 and j = j0 {0}", array[i0, j0]);
}
