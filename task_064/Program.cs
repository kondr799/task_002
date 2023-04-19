// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

string NatNumber(int n, int m)
{
    if (n == m)
        return n.ToString();
    else
        Console.Write($"{NatNumber(n, m + 1)}, ");
    return m.ToString();
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int n = InputInt("Введите положительное число: ");
int m = 1;
Console.WriteLine(NatNumber(n, m));
