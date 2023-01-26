// //Задание 35. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива в диапозоне 
// [10,99]

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
    int size = InsertDigit("введите размер массива");
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array1)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {
        if (i < array1.Length - 1) Console.Write($"{array1[i]}, ");
        else Console.Write($"{array1[i]}]");
    }
    Console.WriteLine();
}

int CheckDigits(int[] array2)
{
    int sum = 0;
    int minRange = 10;
    int maxRange = 99;
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i] > minRange && array2[i] < maxRange + 1) sum++;

    }
    return sum;
}

int[] arr = CreateArray();
PrintArray(arr);

Console.WriteLine($"количество чисел в диапозоне от 10 до 99 равно {CheckDigits(arr)}");


