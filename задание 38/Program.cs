// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    Random rnd = new Random();
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(array[i], 1);
    }
    return array;
}

void PrintArray(double[] array1)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {
        if (i < array1.Length - 1) Console.Write($"{array1[i]}, ");
        else Console.Write($"{array1[i]}]");
    }
    Console.WriteLine();
}

double FindMax(double[] array2)
{
    double result = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i] > result) result = array2[i];
    }
    return result;
}

double FindMin(double[] array3)
{
    double result = array3[0];
    for (int i = 0; i < array3.Length; i++)
    {
        if (array3[i] < result) result = array3[i];
    }
    return result;
}

double[] arr = CreateArrayRndInt(5, 0, 9);
PrintArray(arr);
Console.WriteLine($"разница максимального и минимального значения массива = {Math.Round((FindMax(arr) - FindMin(arr)), 1)}");

