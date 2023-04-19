// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void SplitMatrix(int[,] m, int step)
{
// Обходим периметр с учётом смещения
// -> Заполняем строку сверху вправо
    for (int i = step + 1; i < m.GetLength(1) - step; i++)
        m[step, i] = m[step, i - 1] + 1;
// заполняем столбец справа вниз
    for (int i = step + 1; i < m.GetLength(0) - step; i++)
        m[i, m.GetLength(1) - step - 1] = m[i - 1, m.GetLength(1) - step - 1] + 1;
// <- Заполняем строку внизу влево
    for (int i = m.GetLength(1) - step - 2; i >= step; i--)
    m[m.GetLength(0) - step - 1,i] = m[m.GetLength(0) - step - 1, i + 1] + 1;    
// Заполняем столбец слева вверх
    for (int i = m.GetLength(0) - step - 2; i > step; i--)
    m[i, step] = m[i + 1, step] + 1;
// Обход периметра закончен, если внутри него есть незаполненные ячейки, рекурсивно вызываем эту же функцию
    if (m[step + 1, step + 1] == 0)
    {
        m[step + 1, step + 1] = m[step + 1, step] + 1;
        SplitMatrix(m, step + 1);
    }
}

int[,] CreateMatrix()
{
    Console.Write("Введите размер матрицы: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[0]];
    matrix[0, 0] = 1;
    SplitMatrix(matrix, 0);
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:d2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
int[,] matrix = CreateMatrix();
PrintMatrix(matrix);