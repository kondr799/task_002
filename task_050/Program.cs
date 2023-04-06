// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

Console.Write("Введите размер массива x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива y: ");
int y = Convert.ToInt32(Console.ReadLine());
double[,] RandomArray = new double[x,y];
Console.Write("Введите позицию строки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int y2 = Convert.ToInt32(Console.ReadLine());

void mas(int x, int y)
{
    int i,j;
    Random randarin = new Random();
    for (i = 0; i < x; i++)
    {
        Console.WriteLine();
        for (j = 0; j < y; j++)
        {
            RandomArray[i,j] = randarin.NextDouble();
            Console.Write($"{RandomArray[i,j]:F2}");
        }
        Console.WriteLine();
    }
}

mas(x, y);
if(x2 < 1 || y2 < 1)
Console.Write("Позиции строк не могут быть отрицательными");
else if (x2 <= x + 1 && y2 <= y + 1)
Console.Write($"Значение равно {RandomArray[x2 - 1, y2 - 1]:F2}");
else Console.Write("Элемента в массиве нет");