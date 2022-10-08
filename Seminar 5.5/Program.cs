// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Не работает, почему не могу разобраться.

int[] array = MyArray(5, 1, 9);
Console.WriteLine(String.Join(" ", array));
int[] result = new int[array];
Console.WriteLine(String.Join(" ", result));
int Size= 0;

if(array.Length %2==0)
{
    Size = array.Langth/2;
}
else
{
    Size = array.Length/2+1;
}

for(int i = 0; y=array.Length-1; i<Size, i++, y--)
{
    array[x] = array[i];
    array[y] = array[y];
    
    if(i!=y)
    {
        array[i] = array[x]*array[y];
    }
    else
    {
        array[i]=array[y];
    }
    return array[i];
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
