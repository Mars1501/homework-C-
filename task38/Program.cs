// Задача 38
// Найдите разницу между максимальным и минимальным элементов массива.

double[] num = new double[5]{3, 7, 22, 2, 78};
int imax = 0;
int imin = 0;
double result = 0;
for(int i = 0; i < 5; i++)
{
    
    if (num[i] > num[imax])
    {
        imax = i;
    }
    else if(num[i] < num[imin])
    {
        imin = i;
    }
    
}
result = num[imax] - num[imin];
Console.WriteLine(result);