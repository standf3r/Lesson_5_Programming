// Задача 35.Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//
const int size_N=123;

int [] array = new int[size_N];

void print_array()
{
Console.Write("[");
for(int i=0; i < size_N-1; i++)
{
Console.Write($"{array[i]}, ");
}
Console.WriteLine($"{array[size_N-1]}]");
}

void init_array()
{
Random rnd = new Random();
for(int i=0; i<size_N; i++)
{
array[i]=rnd.Next(-1000,1000);
}
}

int my_count()
{
int ret=0;
for(int i=0; i<size_N;i++)
{
if ((array[i]>=10)&&(array[i]<=99))
ret++;
}
return ret;
}

init_array();
print_array();
Console.WriteLine($"В массиве {my_count()} элементов, лежащих между 10 и 99");