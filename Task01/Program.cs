﻿// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.Clear();
Console.Write("Введите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
if (num_2 * num_2 == num_1)
{   Console.WriteLine("Первое число является квадратом второго");
}
else 
    Console.WriteLine("Первое число не является квадратом второго");