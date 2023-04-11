// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
FillArrayRandomNumbers(num);
Console.WriteLine("Массив: ");
PrintArray(num);
int sum = 0;

for (int i = 0; i < num.Length; i += 2)
{
    sum = sum + num[i];
}
Console.WriteLine($"всего {num.Length} чисел, нечетных чисел = {sum}");

void FillArrayRandomNumbers(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(1, 10);
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