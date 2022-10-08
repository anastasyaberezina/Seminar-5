// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Не могу разобраться, чтото делаю не то, или возвращаю не то.

int[] array = MyArray(5, 1, 9); //Задали массив
Console.WriteLine(String.Join(" ", array)); //Считали массив
int[] result = new int[array];
Console.WriteLine(String.Join(" ", result));

int Size = 0; //Половинчатый размер массива

if(array.Length%2==0)
{
    Size = array.Langth/2;
}
else
{
    Size = array.Length/2+1;
}


for(int i = 0; int y = 0; y=array.Length-1; i<Size, i++, y--) //Чтото не выходит, чтото не то возвращаю.
{
    array[x] = array[i];
    array[y] = array[y];
     
    if(i!=y)
    {
        array[i] = array[x]*array[y];
        result = array[i];
    }
    else
    {
        array[i]=array[y];
        result = array[i];
    }
    return result;
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
