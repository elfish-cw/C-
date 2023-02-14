// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 2
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 
        {
            matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3   100, 1000   
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

int[,] MultiplyTwoMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    // if (matrix1.GetLength(0) = matrix2.GetLength(1))
    // {
    for (int n = 0; n < matrix1.GetLength(0); n++)
    {
        for (int m = 0; m < matrix2.GetLength(1); m++)
        {
            for (int k = 0; k < matrix2.GetLength(1); k++)
            {
            resultMatrix[n, m] += matrix1[n, k] * matrix2[k, m];
        }
        }
    }
    // }
    // else Console.WriteLine("из этих матриц нельзя сделать произведение, задайте матрицы с одинаковым количествои столбцов и строк");
    return resultMatrix;
}

int[,] matr1 = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(matr1);
int[,] matr2 = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(matr2);

// проверка
// int [,] matr1 = { { 2, 4 }, { 3, 2 } };
// PrintMatrix(matr1);

// int [,] matr2 = { { 3, 4 }, { 3, 3 } };
// PrintMatrix(matr2);
PrintMatrix(MultiplyTwoMatrix(matr1, matr2));