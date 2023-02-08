// Задача 57. Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит 
// сколько раз встречается элемент входных данных.
// (123  1 встречается 3 раза
// 461   2 - 2 раза
// 216)  3 - 1 раза
//       4 - 1 раз
//       6 - 2 раза 

int[,] InputMatrix()
{
    int rows = InsertDigit("введите количество строчек матрицы");
    int columns = InsertDigit("введите количество столбцов матрицы");
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = InsertDigit($"введите {i + 1} {j + 1} элемент матрицы");
        }
    }
    return matrix;
}

int InsertDigit(string text)
{
    Console.WriteLine(text);

    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


void PrintMatrix(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (j < matrix1.GetLength(1) - 1) Console.Write($"{matrix1[i, j],5},");
            else Console.Write($"{matrix1[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}


int[] MatrixToArray(int[,] matrix2)
{
    int[] array = new int[matrix2.Length];
    int k = 0;
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            array[k] = matrix2[i, j];
            k++;
        }
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write($"{arr[i]}]");

    }
    Console.WriteLine();

}

void CountNumbers(int[] array1)
{
    Array.Sort(array1);
    int temp = array1[0];
    int count = 1;
    
    for (int i = 1; i < array1.Length; i++)
    {
        if (array1[i] == temp)
        {
            count++;

        }
        else
        {
            Console.WriteLine($"2число {temp} встречается в матрице {count} раз");
            temp = array1[i];
            count = 1;
        }
        
    }
Console.WriteLine($"3число {temp} встречается в матрице {count} раз");    
}


int[,] matr = InputMatrix();
PrintMatrix(matr);
int[] newArray = MatrixToArray(matr);
PrintArray(newArray);
CountNumbers(newArray);




