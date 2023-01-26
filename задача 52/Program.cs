// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



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



//Печать одномерного массива
void PrintDoubleArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) 
        Console.Write(Math.Round(arr[i],1) + ", ");
    
        else Console.Write($"{Math.Round(arr[i],1)}]");

    }
    Console.WriteLine();

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


double [] AverageColumn(int[,] matrix2)
{
    double[] arrayAverageSum = new double[matrix2.GetLength(1)];
    
    for (int j = 0; j < matrix2.GetLength(1); j++)
    { double averageSum = 0;
        for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            averageSum += matrix2[i,j];  
      
        }
        arrayAverageSum[j] = averageSum / matrix2.GetLength(0);  
    }
   return arrayAverageSum;
}


int[,] mtrx = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(mtrx);
double [] resultArray = AverageColumn(mtrx);
PrintDoubleArray(resultArray);
