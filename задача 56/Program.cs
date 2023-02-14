// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

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

void FindMinSumRow(int[,] matrix2)
{
    int minRow = 0;
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        int sum = 0;
        int minSum = 0;
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            minSum += matrix2[minRow, j];
            sum += matrix2[i, j];

        }
        if (sum < minSum && sum != minSum)
        {
            minSum = sum;
            minRow = i;
        }




        Console.WriteLine(sum);

    }
    Console.WriteLine($"минимальная сумма элемментов масcива в {minRow + 1} строке");
}

int[,] matr = CreateMatrixRndInt(4, 2, 1, 10);
PrintMatrix(matr);
FindMinSumRow(matr);
