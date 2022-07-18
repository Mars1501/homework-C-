// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
double[,] massive = new double[M,N];
Random rnd = new Random();
for(int i = 0; i < M; i++)
{
    for(int j = 0; j < N; j++)
    {
        massive[i,j] = rnd.NextDouble();
        Console.Write(massive[i, j] + " ");
    }
    Console.WriteLine();
}
