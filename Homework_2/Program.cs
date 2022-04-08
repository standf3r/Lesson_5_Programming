//36. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int size = 10;
int[] array = new int[size];
int a = 0;
for(int i = 0; i < size; i++){
array[i] = new Random().Next(1,10);
Console.Write(array[i] + " ");
}
for(int i=0; i < size; i++)
{
    if(i % 2 == 0)
    {
        a = a+array[i];
    }
}
Console.WriteLine($"сумма чисел: {a}");

