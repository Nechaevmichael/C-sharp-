// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void cube(int num)
{
    int i = 1;
    while (i <= num)
    {
        int cube_number = Convert.ToInt32(Math.Pow(i, 3));
        Console.Write($"{i}, ");
        Console.WriteLine(cube_number);
        i += 1;
    }
}
cube(number);