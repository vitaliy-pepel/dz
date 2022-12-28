// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int InputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

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

int[,] MultipPulti(int[,] matrixA, int[,] matrixB, int m, int n)
    {
        var matrixC = new int[m, n];

        for (var i = 0; i < matrixA.GetLength(0); i++)
        {
            for (var j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;

                for (var k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        return matrixC;
    }

Console.Clear();
Console.WriteLine("Введите размерность матриц");
int m = InputNumber("Введите m: ");               //Примешь синюю таблетку — и сказке конец.
int n = InputNumber("Введите n: ");               //Примешь красную таблетку — войдешь в страну чудес.
int[,] matrixA = FillAndPrintArray(m, n);         //Я покажу тебе, насколько глубока кроличья нора (_*_).
int[,] matrixB = FillAndPrintArray(m, n);         //matrix
int[,] answer = MultipPulti(matrixA, matrixB, m, n);
PrintArray2D(matrixA);                        
System.Console.WriteLine();
PrintArray2D(matrixB);                        
System.Console.WriteLine();
PrintArray2D(answer);