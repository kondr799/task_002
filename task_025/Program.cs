// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

double a;
double b;

Console.Write("Введите число А: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число B: ");
b = Convert.ToDouble(Console.ReadLine());

a = Math.Pow(a, b);
Console.WriteLine("Число a равно" + a +"");
Console.ReadLine();




