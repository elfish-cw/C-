// // // Задача 39: Напишите программу, которая перевернёт
// // одномерный массив (последний элемент будет на первом
// // месте, а первый - на последнем и т.д.)
// // [1 2 3 4 5] -> [5 4 3 2 1]
// // [6 7 3 6] -> [6 3 7 6];

int[] CreateArrayRndInt(int size, int min, int max)
{
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

void ReverseArray(int[] array2)
{
    int temp = 0;
    for (int i = 0; i < array2.Length / 2; i++)
    {
        temp = array2[i];
        array2[i] = array2[array2.Length-1-i];
        array2[array2.Length-1-i]=temp;
    }
    }



int[] arr = CreateArrayRndInt(5, 0, 9);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);
// Array.Reverse(arr);
// PrintArray(arr);









