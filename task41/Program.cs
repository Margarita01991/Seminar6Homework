﻿/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3    */ 
Console.Clear();
// int[] FillArray(int size, int leftRange, int rightRange)
// {
//     Random rand = new Random();
//     int [] arr = new int [size];
//     for(int i = 0; i <arr.Length; i++)
//     {
//         arr[i] = rand.Next(leftRange, rightRange +1);
//     }
//     return arr;
// }
// int[] array = FillArray (11,-100, 100);
Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{   
    Console.WriteLine("Введите число");
    int a = Convert.ToInt32(Console.ReadLine());
    array[0 + i] = a;
}
Console.WriteLine('['+ string.Join(", ", array) + ']');
int count = 0;
for(int i = 0; i <array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"{count} числа больше 0");