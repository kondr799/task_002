// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
FillArrayRandomnumbers(num);
Console.WriteLine("Вывод массива: ");
PrintArray(num);
int count = 0;

for (int i = num.Length - 1; i >= 0; i--)
{
    if (num[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($" {num.Length} чисел, {count} четные: ");

void FillArrayRandomnumbers(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] num)
{
    Console.WriteLine($" {num.Length}");
    for (int i = 0; i < num.Length; i++)
    {
        Console.WriteLine($" {num[i]} + ");
    }
    Console.WriteLine();
}

