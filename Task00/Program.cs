﻿// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
Console.Clear();

Console.Write("Введите цело число: ");

int num = Convert.ToInt32(Console.ReadLine());

int square = num * num;

Console.WriteLine($"Квадрат числа {num} равен {square}");