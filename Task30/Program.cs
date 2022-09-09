// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] arr = new int[8];

void FillArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        if (i == 0) Console.Write("[");
        if (i == count - 1) Console.Write($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
}

FillArray(arr);
PrintArray(arr);