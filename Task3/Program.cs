// Задание 23

int[] calculed(int num)
{
   int[] A = new int[num];
   int i = 1;
   while( i <= num)
   {
    A[i-1] = i * i * i;
    Console.WriteLine(A[i-1]);
    i++;}
    return A; 

}

int[] result = calculed(3);


