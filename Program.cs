// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Write("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double a = 0;
int[,] num = new int[m, n];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(-9, 10);
        Console.Write($" {num[i, j]}");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
for (int e = 0; e < num.GetLength(1); e++)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {   
        a = a + num[i, e];      
    }
    a = a / num.GetLength(0);
    Console.Write(Math.Round(a, 2));
    Console.Write("; ");
    a = 0;
}
