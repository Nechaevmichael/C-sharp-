// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

// int[,,] CreateMatrix(int rows, int columns, int size, int min, int max)
// {
//     int[,,] matrix = new int[rows, columns, size];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 matrix[i, j, k] = rnd.Next(min, max + 1);
//             }
//         }
//     }
//     return matrix;
// }

int RecRandom(int num) 
 { 
     int n = new Random().Next(10, 100); 
     if (num == n) return RecRandom(num); 
     else return n; 
 }

int[,,] CreateMatrix(int rows, int col, int depth, int min, int max) 
 { 
     int[,,] matr = new int[rows, col, depth]; 
     int num = new Random().Next(10, 100); 
     for (int i = 0; i < matr.GetLength(0); i++) 
     { 
         for (int j = 0; j < matr.GetLength(1); j++) 
         { 
             for (int k = 0; k < matr.GetLength(2); k++) 
             { 
                 int number = RecRandom(num); 
                 matr[i, j, k] = number; 
             } 
         } 
     } 
     return matr; 
 }

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k], 2}({i},{j},{k}) ");
                else Console.Write($"{matrix[i, j, k], 2}({i},{j},{k}) ");
            }
        }
        Console.WriteLine("");
    }
}

int[,,] result = CreateMatrix(2, 2, 2, 10, 99);
PrintMatrix(result);