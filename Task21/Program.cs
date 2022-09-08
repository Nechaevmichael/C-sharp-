// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите 'x' координату первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 'y' координату первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 'z' координату первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 'x' координату второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 'y' координату второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 'z' координату второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double Dlin(int xa, int ya, int za, int xb, int yb, int zb)
{
    double minusx = xb - xa;
    double minusy = yb - ya;
    double minusz = zb - za;
    minusx *= minusx;
    minusy *= minusy;
    minusz *= minusz;
    return Math.Sqrt(minusx + minusy + minusz);
}
double result = Dlin(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));