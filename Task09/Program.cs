﻿//  Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);

int firstDigit = number / 10;

int secondDigit = number % 10;

if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа {number} -> {secondDigit}");

int max = firstDigit > secondDigit ? firstDigit : secondDigit; // если условие выполняется, тогда 
// первая переменная больше иначе (:) вторая переменная больше
Console.WriteLine($"Наибольшая цифра числа {number} -> {max}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа {number} -> {maxDigit}");

