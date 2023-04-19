// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int Input(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Akkerman(int n, int m)
{
    if (n == 0)
        return m + 1;

    if ((n != 0) && (m == 0))
        return Akkerman(n - 1, 1);

    else return Akkerman(n - 1, Akkerman(n, m - 1));

}

int m = Input("Введите число N: ");
int n = Input("Введите число M: ");
Console.WriteLine($"A {n}, {m} = {Akkerman(n, m)}");