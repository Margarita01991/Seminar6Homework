//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] array = {3, 5, -2, 7, 83};
int N = array.Length;
Console.Write ("Заданный массив: ");
Console.WriteLine('['+ string.Join(", ", array) + ']');
int[] array2 = new int[N];
for (int i = 0; i < array.Length; i++)
{
    array2[i] = array[i];
}
Console.Write ("Копия массива:   ");
Console.WriteLine('['+ string.Join(", ", array2) + ']');