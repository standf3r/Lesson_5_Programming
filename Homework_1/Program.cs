// Задача 34. Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве.

const int size=12;

int[] array = new int[size];
Console.Write("[");
for(int i = 0; i < size; i++)
{
  
  array[i] = new Random().Next(100,1000);
  Console.Write(array[i] + " ");
}
Console.Write("]");
Console.WriteLine();

int plus = 0;
int minus = 0;
for(int i = 0; i < array.Length; i++){
  if (array[i] % 2 == 0){
    plus += 1;
  }else{
    minus += 1;
  }
}

Console.Write($"Всего четных = {plus}");
