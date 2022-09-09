// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Factor(int num)
{
    int res = 1;
    int i = 1;
    while (i <= num)
    {
        res *= i;
        i += 1;
    }
    return res;
}
int result = Factor(number);
Console.WriteLine($"{number} >- {result}");