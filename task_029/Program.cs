// Задача 29: Напишите программу, которая будет создавать массив из 8 символов и заполнять значениями от пользователя

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] array = new int[8];
int n = 8;
    for(int i = 0; i < n; i++)
{
Console.WriteLine("Введите число: ");
array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Конец");