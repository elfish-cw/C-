// Задача 36: Задайте одномерный массив, заполненный случайными
//  числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

int CountNotEvenPossitionNum(int [] array2 )
{
    int sum = 0;
    for (int i = 0; i < array2.Length; i++)
    {if (i%2==0) sum+=array2[i]; 
        } 
    return sum;
} 

int [] arr = CreateArrayRndInt(5,0,9);
PrintArray(arr);
Console.WriteLine($"сумма чисел, cтоящих на нечетных позициях в массиве = {CountNotEvenPossitionNum(arr)}");


