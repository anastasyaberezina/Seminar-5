// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.


int[] array = MyArray(5, 1, 9); //Задали массив
Console.WriteLine(String.Join(" ", array)); //Считали массив
int[] array2 = newArray1(array);
Console.WriteLine(String.Join(" ", array2));

int[] newArray1 (int[] array)
{
    int Size = 0; //Половинчатый размер массива

    if(array.Length%2==0)
    {
    Size = array.Length/2;
    }
    else
    {
    Size = array.Length/2+1;
    }

    int[] newArray2 = new int [Size];
    for(int i = 0, y=array.Length-1; i<Size; i++, y--) //Объявляем 2 счетчика i и y. i идет до Size, y в обр направлении.
    {
    if(i!=y)
    {
        newArray2[i] = array[i]*array[y];
    }
    else
    {
        newArray2[i] = array[i];
    }
    }
return newArray2;  
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
