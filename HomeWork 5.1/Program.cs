/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] array = GetArray (10, 100, 999);
Console.WriteLine(String.Join(" ", array));

int x = 0; //четные
int y = 0; //нечетные
 int count = 0;

for(int i = 0; i<array.Length; i++)
{
    if(array[i]%2==0)
    {
        x=array[i];
        count++;
    }
    else
    {
        y=array[i];
    }
}

Console.WriteLine($"Четные числа в массиве: {String.Join(" ", count)}");



int [] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for(int i=0; i<size; i++)
    {
        res[i]= new Random().Next(minValue, maxValue+1);
    }
    return res;
}