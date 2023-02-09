// //Задача 59. Задайте двумерный массив из целых
// чисел. Напишите программу, которая удалит 
// строку и столбец, на пересечении которых
// расположен наименьший элемент массива.

// [    3,    3,    4  ]
// [    8,    4,   10  ]
// [    5,    8,    8  ]
// Минимальное число = 3
// [    4,   10  ]
// [    8,    8  ]

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

int[,] matr = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(matr);
PrintMatrix(DeleteMinCross(matr));


int[,] DeleteMinCross(int[,] matrix2)
{
    int[,] matrx = new int[matrix2.GetLength(0)-1, matrix2.GetLength(1)-1];
    int minNumber = matrix2[0, 0];
    int rowNumber = 0;
    int collumnNumber = 0;
   

    // находим минимальное число и его индекс в матрице
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {

        for (int j = 0; j < matrix2.GetLength(1); j++)
        {

            if (matrix2[i, j] < minNumber)
            {
                minNumber = matrix2[i, j];
                rowNumber = i;
                collumnNumber = j;
            }
        }

    }
    Console.WriteLine($"Минимальное число = {minNumber}");



    // урезаем матрицу
    int n = 0;
    int m = 0;

    for (int i = 0; i < matrix2.GetLength(0)-1;i++)
    {
      if (n == rowNumber) n++;
        {for (int j = 0; j < matrix2.GetLength(1)-1; j++)
        {
            if (m == collumnNumber) m++;
            matrx[i, j] = matrix2[n, m];
            m++;
        }
        }
        n++;
        m=0;
    }

    return matrx;
}