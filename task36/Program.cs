// Задача 36:  Найдите сумму элементов, стоящих на нечётных позициях.

int length = 4;
int[] mass = new int[length];
Random numRnd = new Random();
int count = 0;
for(int i = 0; i < length; i++)
{
    mass[i] = numRnd.Next(-10, 10);
    Console.WriteLine(" Число " + mass[i]);
    if(i % 2 == 1)
    {
        count =  count + mass[i];
    }
    
}
Console.WriteLine(" Cумма чисел " + count);