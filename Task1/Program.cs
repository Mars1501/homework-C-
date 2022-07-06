// Задание 19

Console.WriteLine("Введите пятизначное число: ");
string val = Console.ReadLine();

int number;

if (int.TryParse(val, out number))
{
if (number.ToString().Length == 5)
{
char[] revtext = number.ToString().ToCharArray();

Array.Reverse(revtext);
string reversedtext = new string(revtext);
if (number.ToString() == reversedtext)
{
Console.WriteLine("Polindrome");
}
else
{
Console.WriteLine("Not a Polindrome");
}
}
else Console.WriteLine("Enter number lenght != 5");
}
else
{
Console.WriteLine("Not Number");
}

