// Задача 34: Напишите программу, которая покажет количество чётных чисел в массиве.

int length = 5;
int[] num = new int[length];
Random numRnd = new Random();
int count = 0;
for(int i = 0; i < length; i++)
{
    num[i] = numRnd.Next(100, 1000);
    Console.WriteLine(" Число " + num[i]);
    
    if(num[i] % 2 == 0)
    {
        count++;
    }
    
}

Console.WriteLine(" Четных чисел " + count);