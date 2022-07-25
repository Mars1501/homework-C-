// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());

int Accerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Accerman(n - 1, 1);
    else
        return Accerman(n - 1, Accerman(n, m - 1));

}
Console.WriteLine($"Число Аккермана: {Accerman(m, n)}");
