/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.[3, 7, 23, 12] -> 19[-4, -6, 89, 6] -> 0*/

int[] array = GetArray (9, 1, 99);
Console.WriteLine(String.Join(" ", array));

int x = 0; //четные позиции
int sum = 0; //искомая сумма
int index = 0; //индекс числа
int count1 = 0; //счетчик четных
int count2 = 0; //счетчик нечетных

for(int i = 0; i<array.Length; i++)
{
    index = i;
    if(index%2==0)
    {
        x=array[index];
        count1++;
    }
    else
    {
        sum=sum+array[i];
        count2++;
    }

}

Console.WriteLine($"Сумма элементов, стоящих на неч позициях: {String.Join(" ", sum)}");

int [] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for(int i=0; i<size; i++)
    {
        res[i]= new Random().Next(minValue, maxValue+1);
    }
    return res;
}