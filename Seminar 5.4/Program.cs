// Задать одномерный массив из 123 случ чисел и определить кол-во элементов, лежащих в отрезке от 10 до 99 включительно.

int[] array = MyArray(123, 0, 150);
Console.WriteLine(String.Join(" ", array));
int result = 0;
int x = 0;

for(int i = 0; i<array.Length; i++)
{
    array[x] = array[i];
    
    if((array[x]>=array[9])&&(array[x]<=array[98]))
    {
        result = array[i];
        Console.Write($"[{String.Join(";", result)}]");
    }
}

int[] MyArray (int size, int a, int b)
{
    int[] res = new int[size];
    for(int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(a, b+1);
    }
    return res;
}