// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите цифру: ");
string digit = Console.ReadLine();
if (digit.Length >= 3) Console.Write(digit[2]);

else Console.WriteLine("Третьей цифры нет, введите ещё раз");

int digit_1 = Convert.ToInt32(digit); // Для дальнейшего использования в расчётах