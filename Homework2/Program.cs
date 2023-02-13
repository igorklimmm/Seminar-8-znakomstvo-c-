// Задача 56: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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
int minsum = Int32.MaxValue;
int IndexString = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {   
        {
        sum = sum + matrix[i,j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            IndexString++;
        }
    }
}
Console.WriteLine("Строка с наименьшей суммой: " + IndexString);

