﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrinsRndInt(int rows, int columns, int min, int max)
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2} ");
            else Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine("|");
    }
}

int[,] array2D = CreateMatrinsRndInt(3, 4, 1, 10);
PrintMatrix(array2D);

double[] ArithmeticDigit(int[,] matrix)
{
    double[] ArithmeticMean = new double[matrix.GetLength(1)];
    double rowSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        rowSum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            rowSum += matrix[i, j];
        }
        ArithmeticMean[j] = rowSum / matrix.GetLength(0);
    }
    return ArithmeticMean;
}

void PrintArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{Math.Round(array[i], 1),1}; ");
        else Console.Write($"{Math.Round(array[i], 1), 1}.");
    }
}
double[] arithmetic = ArithmeticDigit(array2D);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArrayDouble(arithmetic);