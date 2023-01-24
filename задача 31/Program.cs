// Задача 31. Задайте массив из 12 чисел в промежутке (-9;9)
// Найдите сумму отрицательных и положительных элементов массива.
int InsertDigit(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateArray()
{
    int min = InsertDigit("введите минимальное значение массива");
    int max = InsertDigit("введите максимальное значение массива");
    int size = InsertDigit("задайте размер массива");
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;

}



void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) 
        Console.Write(arr[i] + ", ");
    
        else Console.Write($"{arr[i]}]");

    }
    Console.WriteLine();

}


int SumPositiveElements(int[] array1)
{
    int sum = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] > 0)
         sum = sum + array1[i];
    }
    return sum;
}
int SumNegativeElements(int[] array2)
{
    int summ = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i] < 0)
         summ = summ + array2[i];
    }
    return summ;
}

int[] arr1 = CreateArray();
PrintArray(arr1);
int result = SumPositiveElements(arr1);
Console.WriteLine($"сумма положительных чисел массива = {result}");
Console.WriteLine($"сумма отрицательных чисел массива = {SumNegativeElements(arr1)}");