// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillAndPrintArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

Console.Clear();
int m = 4;
int n = 4;    
int[,] matrix = FillAndPrintArray(m, n);
PrintArray2D(matrix);
System.Console.WriteLine();
Minimal();

void Minimal()
{
    int min = 999999999;
    int num = 0;
    for (int i = 0; i < n; i++)
    {
        int s = 0;
        for (int j = 0; j < m; j++)
        {
            s += matrix[i, j];
        }
        if (s < min)
        {
            min = s;
            num = i;
        }
    }
    System.Console.WriteLine($"Минимальная сумма эл-тов: {min} | Номер строки: {num}");
}
