// // Задача 54: Задайте двумерный массив. Напишите 
// программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

  

int[,] SortNumbersInRows(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        int temp = 0;
      
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
                for (int k = j+1; k < matrix1.GetLength(1); k++)
                {
                    if (matrix1[i, j] < matrix1[i, k])
                    {
                        temp = matrix1[i, j];
                        matrix1[i, j] = matrix1[i, k];
                        matrix1[i, k] = temp;
                    }
                }
                
            }

        }
        return matrix1;
    }



    int[,] matr = CreateMatrixRndInt(3, 6, 1, 10);
    PrintMatrix(matr);
    SortNumbersInRows(matr);
    Console.WriteLine();
    PrintMatrix(matr);


