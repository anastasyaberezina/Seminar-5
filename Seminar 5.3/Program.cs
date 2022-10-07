// Задайте массив. Напишите программу, которая определяет присутствует ли заданное число в массиве.

Console.WriteLine("Введите число: ");
int[] array = MyArray(9, 1, 99);
int x = int.Parse(Console.ReadLine());
Console.WriteLine(String.Join(" ", array));
int result1 = 0;
int result2 = 0;

for(int a = 0; a<array.Length; a++)
{
if(array[a]!=x)
{
    result1=array[a];
    Console.WriteLine($"Заданного числа в массиве НЕТ!");
}
else
{
    result2 = array[a];
    Console.WriteLine($"Заданное число {result2} присутствует в массиве.");
}
}

int[] MyArray (int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}