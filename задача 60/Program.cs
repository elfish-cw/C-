﻿// Задача 60. Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j, 0] = rnd.Next(min, max + 1);
            for (int k = 1; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
                if (matrix[i, j, k] == matrix[i, j, k - 1])
                    matrix[i, j, k] = rnd.Next(min, max + 1);
                    
                // ? не придумала, что делать если сгенерирует случайным образом такое же число
            }
        }
    }
return matrix;
}

void Print3Matrix (int [,,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(2); k++)
            {
                Console.Write($"{matrix1[i,j,k]}({i},{j},{k}) ");
              
            }
        }
        Console.WriteLine();
    }

}


int[,,] matr = CreateMatrixRndInt(2, 2, 2, 10, 100);
Print3Matrix(matr);