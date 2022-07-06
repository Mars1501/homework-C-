// Задание 27


Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
    int sum = 0;
    while(a > 0)
    {
        sum = sum + a % 10;
        a = a / 10;
    }

Console.WriteLine(sum);    