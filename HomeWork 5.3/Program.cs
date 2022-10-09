/*Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.[3 7 22 2 78] -> 76* (double)*/


int[] array = MyArray(9, 10, 90); //Задали массив
Console.WriteLine(String.Join(" ", array)); //Считали массив
Console.WriteLine($"Разница между максимальным и минимальным значением равна {newArray1(array)}");

int newArray1 (int[] array)
{
    int max = array[0];
    int min = array[0];
    for(int i = 0; i<array.Length; i++)
    {
    if (array[i]>max)
    {
        max = array[i];
    }
    else if(array[i]<min)
    {
        min = array[i];
    }
    }
    Console.WriteLine($"max={max} and min={min}");
    return max - min;
}
    

int[] MyArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for(int i=0; i<size; i++)
    {
        res[i]= new Random().Next(minValue, maxValue+1);
    }
    return res;
}
