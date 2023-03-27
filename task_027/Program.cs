// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.Write("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = 1;
for (int i = 1; i < n; i++)
{
    res += n % 10;
    n /= 10;
}
Console.WriteLine($"Сумма цифр = {res}");
