﻿// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int sum = default; // значение по умолчанию, будет 0
    
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
    
}
int result = SumNumbers(number);
Console.WriteLine(result);

int SumNumbers1(int num)
{
    int i = 1;
    int sum = default;
    while (i <= num)
    {
        sum += i;
        i += 1;
    }
    return sum;
}
int res = SumNumbers1(number);
Console.WriteLine(res);