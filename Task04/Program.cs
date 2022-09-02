Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int maximum = a;

if (maximum < b)
{
    maximum = b;
}
else
{
    maximum = a;
}
if (maximum < c)
{
    maximum = c;
}


Console.Write(maximum);