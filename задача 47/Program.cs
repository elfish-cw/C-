// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int InsertDigit(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
        Random rnd2 = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int minus = rnd2.Next(-1,2);
            if (minus == 0) 
            {minus = minus+1;
            matrix[i, j] = Math.Round(rnd.NextDouble()*(max-min)*minus,1);
            }
            matrix[i, j] = Math.Round(rnd.NextDouble()*(max-min)*minus,1);
            
        }
    }
    return matrix;
}


// Печать массива int
void PrintMatrix(double[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("]");
    }
}

int m = InsertDigit("введите количесто строк");
int n = InsertDigit("введите количесто рядов");
double[,] arr1 = CreateMatrixRndDouble(m, n, -50, 50);
PrintMatrix(arr1);
