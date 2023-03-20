// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
int length = value.ToString().Length;

if (length >= 3)
{
    while (value > 999)
    {
        value = value / 10;
    }
    int result = value % 10;
    Console.WriteLine("Третья цифра: " + result);
}
else
{
    Console.WriteLine("Число меньше трёх");
}

