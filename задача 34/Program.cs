// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. 
// Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int InsertDigit(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateArray ()
{
int min = InsertDigit("введите минимальное значение массива");
int max = InsertDigit("введите максимальное значение массива");
int size = InsertDigit("введите размер массива");
Random rnd = new Random();
int [] array = new int [size];
for (int i = 0; i < array.Length; i++)
{
    array[i]=rnd.Next(min, max+1);
}
return array;
}

void PrintArray (int [] array1)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {if (i<array1.Length-1) Console.Write($"{array1[i]}, ");
    else Console.Write($"{array1[i]}]");   
    }
Console.WriteLine();
}


int [] arr = CreateArray();
PrintArray(arr);


