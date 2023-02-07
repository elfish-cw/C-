// Задача 55. Задайте двумернй массив 
// Напишите программу, 
// которая заменяет строки на столбцы, 
// если это возможно.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;


}


// Печать двумерного массива int
void PrintMatrix(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (j < matrix1.GetLength(1) - 1) Console.Write($"{matrix1[i, j],5} ");
            else Console.Write($"{matrix1[i, j],5}");
        }
        Console.WriteLine();
    }
}

// void ReplaceRowsToColumns(int[,] matrix2)
// {
//     for (int i = 1; i < matrix2.GetLength(0); i++)
//     {
//         for (int j = 0; j < i; j++)
//         {
//             int temp = matrix2[i, j];
//             matrix2[i, j] = matrix2[j,i];
//             matrix2[j, i] = temp;
//         }
//     }
// }

// или можно так
void ReplaceRowsToColumns(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = i; j < matrix2.GetLength(1); j++)
        {
            int temp = matrix2[i, j];
            matrix2[i, j] = matrix2[j,i];
            matrix2[j, i] = temp;
        }
    }
}

int[,] mtrx = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(mtrx);
if (mtrx.GetLength(0) == mtrx.GetLength(1))
{
    ReplaceRowsToColumns(mtrx);
    Console.WriteLine();
    PrintMatrix(mtrx);
}

else Console.WriteLine("невозможно");
