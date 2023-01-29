// Задача 53. Задайте двумерный массив.
// Напишите программу, которая поменет местами 
// первую и последнюю строку.

// Создание рандомного двумерного массива int

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

void ReplaceFirstLastRows (int[,] matrix2)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        int temp = matrix2[0,j];
        matrix2[0,j] = matrix2[matrix2.GetLength(0)-1,j];
        matrix2[matrix2.GetLength(0)-1,j] = temp;
    }
}

int [,] mtrx = CreateMatrixRndInt (3,3,0,10);
PrintMatrix(mtrx);
ReplaceFirstLastRows(mtrx);
Console.WriteLine();
PrintMatrix(mtrx);
