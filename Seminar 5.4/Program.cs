// Задать одномерный массив из 123 случ чисел и определить кол-во элементов, лежащих в отрезке от 10 до 99 включительно.
//Не вполне уверена, что решила правильно, потому что не пойму в отрезке между элементами со значениями 10 и 99 или индексами?

int[] array = MyArray(123, 0, 150); //задали массив
Console.WriteLine(String.Join(" ", array)); //считали массив

int count = 0;
int min = array[9]; //10й элемент массива
int max = array[98]; //99 элемент массива
int result = 0;  //кол-во элементов в отрезке

for(int i = 0; i<array.Length; i++)
{
    if((min<=array[i])&&(array[i]<=max))
    { 
        result=array[i];
        count++;
    }
}
    Console.WriteLine($"Количество элементов в отрезке{count}");


int[] MyArray (int size, int a, int b)
{
    int[] res = new int[size];
    for(int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(a, b+1);
    }
    return res;
}