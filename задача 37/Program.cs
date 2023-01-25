// // Задача 37. Найти произведение пар чисел в одномерном массиве
// Парой считаем первый и последний элемент,
// второй и предпоследний и тд. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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


int[] NewMassive(int[] array2)
{
    int size = array2.Length%2 !=0 ? array2.Length/2 +1 : array2.Length/2;
    int[] resArray = new int [size];
     for (int i = 0; i < resArray.Length; i++)
        {
           resArray[i] = array2[i]*array2[array2.Length-i-1];
            }
    
    if (array2.Length %2==1) resArray[size-1]=array2[array2.Length/2];
    return resArray;
}



    int[] arr = CreateArray();
    PrintArray(arr);
    PrintArray(NewMassive(arr));

