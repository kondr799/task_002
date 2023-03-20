// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");
int value = Convert.ToInt32(Console.ReadLine());
int length = value.ToString().Length;
if (length == 3)
{
    int result = value / 10 % 10;
    Console.WriteLine("Введите второе число: " + result);
}
else
{
    Console.WriteLine("Не указано трёхзначное число");
}