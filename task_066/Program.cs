// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int Input(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountSum(int m, int n)
{
    if (m == n)
    return n;
    return n + 1 + CountSum(m, n -1);
}

int m = Input("Введите число M: ");
int n = Input("Введите число N: ");

Console.WriteLine($"Сумма чисел от {m} до {n} = {CountSum(m, n)}");
