// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillArrayWithRandom (int [,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        matrix[i, j] = new Random().Next (0, 10);
        Console.Write(matrix [i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void PrintArrayWithRandom(int[,] matrix)
{
   for (int i = 0; 1 < matrix. GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
      Console.Write(matrix[i, j] + "\t");
      }
      Console.WriteLine();
   }
   Console.WriteLine();
}

Console.WriteLine("Введите размер двумерного массива (вертикаль): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер двумерного массива (горизонталь): ");
int n = Convert.ToInt32(Console. ReadLine());
Console.WriteLine();
Console.WriteLine("Ваш двумерный массив: ");
int [,] matrix = new int [m, n];
Console.WriteLine();
FillArrayWithRandom(matrix, m, n);
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1)-1; j++)
    {
        for (int j1 = 0; j1 < matrix.GetLength(1)-1; j1++)
        {
            if (matrix[i,j1] < matrix[i,j1+1])
            {
            int temp = 0;
            temp = matrix[i, j1];
            matrix[i,j1]= matrix[i, j1+1];
            matrix[i, j1+1] = temp;
            }
        }
    }
}
Console.WriteLine("Упорядоченный массив:" );
PrintArrayWithRandom(matrix);
