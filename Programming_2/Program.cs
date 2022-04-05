// Задача 33. Напишите программу замена элементов массива: + элементы замените на соответствующие -, и наоборот

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