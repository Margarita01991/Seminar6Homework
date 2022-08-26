//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. (использовать рекурсию) 4 -> 24; 5 -> 120
Console.Clear();
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int Product(int N)
{
    if (N == 1) return 1;
    else return N * Product(N-1);
}
Console.WriteLine(Product(N));