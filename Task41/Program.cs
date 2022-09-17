// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите желаемое количество цифр: ");
int countDigit = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int sizeArray)
{
    int[] array = new int[sizeArray];
    int i = 0;
    while (i < sizeArray)
    {
        Console.Write($"Введите цифру №{i + 1}: ");
        int digit = Convert.ToInt32(Console.ReadLine());
        array[i] = digit;
        i += 1;
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("Введённые цифры пользователем: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}");
    }
}
int SearchDigit(int[] arr)
{
    int count = 0;
    int j = 0;
    while (j < arr.Length)
    {
        if (arr[j] > 0) count += 1;
        j += 1;
    }
    return count;
}

int[] arr = CreateArray(countDigit);
PrintArray(arr);
int result = SearchDigit(arr);
Console.WriteLine($"Количество чисел больше 0 составляет: {result}");

// Console.Write("Введите желаемое количество цифр: ");
// int count = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[count];
// int i = 0;
// while (i < count)
// {
//     Console.Write("Введите цифру: ");
//     int digit = Convert.ToInt32(Console.ReadLine());
//     array[i] = digit;
//     i += 1;
// }
// int countUser = 0;
// int j = 0;
// while (j < array.Length)
// {
//     if (array[j] > 0) countUser += 1;
//     j += 1;
// }
// Console.WriteLine($"Пользователь ввёл количество чисел больше 0 равное {countUser}");