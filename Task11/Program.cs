// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(10, 1000);
int MaxDigit(int number)
{
    int firstDigit = number / 100 * 10;
    int secondDigit = number % 10;
    return firstDigit + secondDigit;
}
int result = MaxDigit(number);
Console.WriteLine($"{number} -> {result}");