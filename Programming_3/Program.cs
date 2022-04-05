// Задача 33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве

int [] array = new int [12]; // создаем массив длиной 12
void print_array() // создае метор в котром указываем условие
{
    for(int i=0; i < 12-1; i++) // добавляем переменную i, указываем условие что если этот i меньше 12-1, и увеличиваем индекс на один
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[12-1]}]");
} 

void init_array()
{
    Random rnd = new Random();
    for (int i=0; i < 12; i++)
    {
        array[i] = rnd.Next(-10,11);
    }
}

void process_array()
{
    for(int i=0; i<12; i++)
    {
        array[i]= -1* array[i];
    }
}

 init_array();
 print_array();
 process_array();
 print_array();

 bool my_exist(int B)
 {
     bool ret=false;
     for(int i=0; i<12; i++)
     {
         if (B==array[i]) {ret=true;}
     }
     return ret;
 }

 Console.Write("Введите число: ");
 int A = Convert.ToInt32(Console.ReadLine());

 if(my_exist(A))
 {
     Console.WriteLine($"Число {A} пристутвует в массиве");
 }
 else
 {
     Console.WriteLine($"Число {A} отсутсвует в массиве");
 }