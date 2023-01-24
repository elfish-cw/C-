// Задание 33. Задайте массив.
// Напишите программу, которая проверяет, 
// есть ли заданное число в массиве.

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

bool CheckNum (int num, int [] arr2)
{for (int i = 0; i < arr2.Length; i++)
{
    if (arr2[i]==num)
    return true;
}
return false;
}

int [] arr = CreateArray();
PrintArray(arr);
int number = InsertDigit("введите искомое число");
;
Console.WriteLine(CheckNum (number, arr) ? "искомое число есть в массиве": "искомого числа нет в массиве");


