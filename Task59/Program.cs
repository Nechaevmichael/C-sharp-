// Задача 59. Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент
// массива.
// Задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// наименьший элемент - 1, на выходе получим массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j], 2} ");
            else Console.Write($"{matr[i, j], 2} ");
        }
        Console.WriteLine("|");
    }
}

int FindMin(int[,] arr)
{
    int min = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (min > arr[i, j])
            {
                min = arr[i, j];
            } 
        }
    }
    return min;
}

int[,] matrix = CreateMatrix(4, 4, 1, 10);
PrintMatrix(matrix);
int minimum = FindMin(matrix);
Console.WriteLine();
Console.WriteLine($"Минимальное значение массива равно: {minimum}.");