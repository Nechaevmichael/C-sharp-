// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите 'x' координату первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 'y' координату первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 'x' координату второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 'x' координату второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Dlin(int xa, int ya, int xb, int yb)
{
    double minusx = xb - xa;
    double minusy = yb - ya;
    minusx *= minusx;
    minusy *= minusy;
    return Math.Sqrt(minusx + minusy);
}
double result = Dlin(x1, y1, x2, y2);
Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));