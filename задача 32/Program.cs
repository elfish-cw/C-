// Задача 32. Напишите программу замена элементов
// массива: положительные элементы замените на соответсвующие 
// отрицательные и наоборот.
// [-4,-8,8,2] -> [4,8,-8,-2]
int InsertDigit(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateArray()
{
    int min = InsertDigit("введите минимальное значение массива:");
    int max = InsertDigit("введите максимальное значение массива:");
    int size = InsertDigit("задайте размер массива:");
    int[] array = new int[size];
    Random rnd = new Random();
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
        if (i < array1.Length - 1)
            Console.Write($"{array1[i]}, ");
        else Console.Write($"{array1[i]}]");
    }
    Console.WriteLine();
}

int [] ChangeArrayElements(int[] array2)
{for (int i = 0; i < array2.Length; i++)
{
    array2[i] *= -1;
}
return array2;

}
int[] arr = CreateArray();
PrintArray(arr);
PrintArray(ChangeArrayElements(arr));
