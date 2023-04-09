// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[] ReadPosition()
{
    Console.Write("Введите необходимый элемент: ");
    int[] Position = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    return Position;
}

void FindElement(int[,] matrix, int[] Position)
{
    if (Position[0] < matrix.GetLength(0) && Position[1] < matrix.GetLength(1))
    {
        Console.Write($"{matrix[Position[0], Position[1]]}");
    }
    else
        Console.Write("Элемента нет.");
}

Console.Write("Введите размерность матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] Matrix = new int[size[0], size[1]];
InputMatrix(Matrix);
int[] Index = ReadPosition();
FindElement(Matrix, Index);

