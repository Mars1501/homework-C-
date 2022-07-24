// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
int depth = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[rows, columns, depth];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        for (int k = 0; k < depth; k++)
        {
            matrix[i, j, k] = new Random().Next(10, 100);
            Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k})\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
