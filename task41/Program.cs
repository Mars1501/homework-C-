// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите элементы(через пробел): ");
int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < num.Length; i++)
{
    if (num[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Положительных чисел:  {count}");

