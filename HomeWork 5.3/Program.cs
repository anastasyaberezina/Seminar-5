/*Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.[3 7 22 2 78] -> 76* (double)*/
// Не получается решить.

int[] array = GetArray (5, 1, 99);
Console.WriteLine(String.Join(" ", array));
//int[] result1 = new int[array1];
//int[] result2 = new int[array2];



int min = 0; //мин число массива
int max = 0; //макс число массива
int x = 0; //индекс переменной
int y = 0; //разница

Console.WriteLine(String.Join(" ", min));

for(int i = 0; i<array.Length; i++)
{ 
    if(array[x]<array[i])
    {
        min = array[x];
        max = array[i];
    }
    else
    {
       min = array[i];
       max= array[x];
    }
}


Console.WriteLine(y);

int [] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for(int i=0; i<size; i++)
    {
        res[i]= new Random().Next(minValue, maxValue+1);
    }
    return res;
}