//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] array = {3, 5, -2, 7, 83};
int N = array.Length;
Console.WriteLine('['+ string.Join(", ", array) + ']');
int[] array2 = new int[N];
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array2[i] = array[i];
    Console.Write(array2[i]);
    Console.Write(",");
}
Console.Write("]");
