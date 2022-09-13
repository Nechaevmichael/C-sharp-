// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите любое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int sum(int num)
{
    int result1 = 0;
    while(num > 0)
    {
        result1 += num % 10;
        num /= 10;
    }
    return result1;
}
int result2 = sum(number1);
Console.WriteLine($"Сумма цифр числа {number1} равна {result2}");

// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 0 && number <= 999999)
// {
//     int num1 = number % 10;
//     int num2 = number / 10 % 10;
//     int num3 = number / 100 % 10;
//     int num4 = number / 1000 % 10;
//     int num5 = number / 10000 % 10;
//     int num6 = number / 100000 % 10;
//     int res = num1 + num2 + num3 + num4 + num5 + num6;
//     Console.WriteLine($"{number} >- {res}");
// }

// int sumDigit(int num)
// {
//     int num1 = number % 10;
//     int num2 = number / 10 % 10;
//     int num3 = number / 100 % 10;
//     int num4 = number / 1000 % 10;
//     int num5 = number / 10000 % 10;
//     int num6 = number / 100000 % 10;
//     int res = num1 + num2 + num3 + num4 + num5 + num6;
//     return res;
// }
// int result = sumDigit(number);
// Console.WriteLine($"{number} >- {result}");