// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. 
// Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int InsertDigit(string text)
// {
//     Console.WriteLine(text);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

int[] CreateArrayRndInt(int size, int min, int max)
{
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

int CountEvenNum(int [] array2 )
{
    int sum = 0;
    for (int i = 0; i < array2.Length; i++)
    {if (array2[i]%2==0) sum++; 
        } 
    return sum;
} 

int [] arr = CreateArrayRndInt(6,99,999);
PrintArray(arr);
Console.WriteLine($"количество четных чисел в массиве = {CountEvenNum(arr)}");


