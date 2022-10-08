// Задайте массив. Напишите программу, которая определяет присутствует ли заданное число в массиве.

Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine()); //введенное число

int[] array = MyArray(10, -99, 99); //Назначили массив
Console.WriteLine(String.Join(" ", array));

for(int a = 0; a<array.Length; a++)
{
if(array[a]==x)
{
    Console.WriteLine($"Заданное число {array[a]} присутствует в массиве.");
}
}

int[] MyArray (int size, int minValue, int maxValue) //Заполняем массив рандомными числами
{
    int[] res = new int[size];
    for(int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}