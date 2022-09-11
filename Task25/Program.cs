// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень введённого Вами числа: ");
int degreeNumber = Convert.ToInt32(Console.ReadLine());

int Degree(int num, int degnum)
{
    if (degnum == 0)
    {
        num = 1;
        return num;
    }
    
    else
    {
        int res = 1;
        int i = 0;
        while (i < degnum)
        {
            res *= num;
            i += 1;
        }
        return res;
    }
}
int result = Degree(number, degreeNumber);
Console.WriteLine($"{number}, {degreeNumber} -> {result}");
