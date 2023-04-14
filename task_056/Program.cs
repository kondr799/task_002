// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreatMatrix(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1}  ");
            else Console.Write($"{matrix[i, j],1}");
        }
        Console.WriteLine();
    }
}

void SumMatrix(int[,] matrix)
{
    int index = 0, minSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int Sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum += matrix[i, j];
        }    
        if (i == 0)
        {
            minSum = Sum;
        }
        else if (Sum < minSum)
        {
            minSum = Sum;
            index = i;
        }
    }
    String Line = String.Empty;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Line += matrix[index, j] + " ";
    }
    Console.WriteLine($"Строка с минимальной суммой элементов равна: {Line}. ");
}

Console.Clear();
Console.WriteLine("Ввести размер массива: ");
int[,] array2d = CreatMatrix(4, 4, 1, 9);
PrintMatrix(array2d);
SumMatrix(array2d);