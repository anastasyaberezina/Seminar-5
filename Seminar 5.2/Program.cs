// Написать программу замены элементов массива с положительных на отрицательные.

int[] array = GetArray(10, -10, 10);
Console.WriteLine(String.Join(" ", array));

for(int i = 0; i<array.Length; i++)
{
  array[i]= array[i]*(-1);
}


Console.WriteLine($"Массив с заменой чисел {String.Join(" ", array)}");

int[] GetArray(int size, int minValue, int maxValue)
{
  int[] res = new int[size];
  for(int i = 0; i<size; i++)
  {
    res[i]= new Random().Next(minValue, maxValue+1);
  }
  return res;
}
