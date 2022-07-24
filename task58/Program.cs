// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите число строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] firstArray = new int[rows, columns];
Console.WriteLine("Первый массив: ");
FillArray(firstArray, rows, columns);
Console.WriteLine();
int[,] secondArray = new int[rows, columns];
Console.WriteLine("Второй массив: ");
FillArray(secondArray, rows, columns);
Console.WriteLine();
void FillArray(int[,] matrix, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MultArray(int[,] firstMatrix, int[,] secondMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            Console.Write(firstMatrix[i, j] * secondMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Произведение двух массивов: ");
MultArray(firstArray, secondArray);