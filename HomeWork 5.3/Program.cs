/*Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.[3 7 22 2 78] -> 76* (double)*/


int[] array = MyArray(9, 10, 90); //Задали массив
Console.WriteLine(String.Join(" ", array)); //Считали массив
int[] array2 = newArray1(array);
Console.WriteLine(String.Join(" ", array2));
Console.WriteLine(newArray1(" ", array));
Console.WriteLine($"Разница между максимальным и минимальным значением равна {max - min}");
int max = 0;
int min = 0;

int[] newArray1 (int[] array)
{
    int max = array[90];
    int min = array[10];
    for(int i = 0; i<array.Length; i++)
    {
    if (array[i]>max)
    {
        max = array[i];
    }
    else(array[i]<min)
    {
        min = array[i];
    }
    }
return newArray1;
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
