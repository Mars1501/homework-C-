Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();
int i = num.Length;

if(i == 5)
{
    if(num[0] == num[i - 1] && num[1] == num[i - 2])
    {
        Console.WriteLine("Число является полиндромом");
    }
    else
    {
        Console.WriteLine("Число не является полиндромом"); 
    }
}

