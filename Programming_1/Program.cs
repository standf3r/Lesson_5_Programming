// 



int [] macos = new int [12]; // создаем какой то массив с названием macos длиной 12 элементов
int len = macos.Length; // указывает переменную с указанием текущей длины массива
int index = 0; // указываем индекс 
int resnegative = 0; // добавляем переменную с положительными числами
int respositive = 0; // добавляем переменную с отрицательными числами
void MassiveStart(int[] array) // добавляем метор в которой указываем новый массив
{

while (index<len) // пока индекс меньше длины массива
{
array[index] = new Random().Next(-9,10); // создавай рандомные числа от -9 до 10
index++; // увеличивая индекс на один
}
for(int i = 0; i < len; i++){ // for ([действия_до_выполнения_цикла]; [условие]; [действия_после_выполнения])
    if(array[i] > 0){ // если массив с индексом 0 больше 0
        respositive += array[i]; // прибавляй 0 к этому индексу
    }else {
        resnegative += array[i]; // иначе прибавляй к этой переменной
    }
    Console.Write ($"{macos [i]}"); //выводит сам массив с этими рандомными числами
}
}
MassiveStart(macos);
Console.WriteLine();
Console.WriteLine($"колличесво положительных {respositive}");
Console.WriteLine($"колличесво отрицательных {resnegative}");
//