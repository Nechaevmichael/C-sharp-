// Напишите программу, которая на вход принимает два числа и выдаёт, какое число болшее, а какое меньшее.

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write($"max = {a}");
}
else
{
    Console.WriteLine($"max = {b}");
}