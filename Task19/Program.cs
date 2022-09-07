// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите любое пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int num_1 = number / 10000;
// int num_2 = number % 10;
// int num_3 = number / 1000 % 10;
// int num_4 = number / 10 % 10;
// if (num_1 == num_2 && num_3 == num_4)
// {
//     Console.WriteLine($"{number} -> да");
// }
// else Console.WriteLine($"{number} -> нет");

void Polindrom(int num)
{
    int num_1 = number / 10000;
    int num_2 = number % 10;
    int num_3 = number / 1000 % 10;
    int num_4 = number / 10 % 10;
    if (num_1 == num_2 && num_3 == num_4) Console.Write($"{number} -> да");
    else Console.WriteLine($"{number} -> нет");
}

Polindrom(number);
