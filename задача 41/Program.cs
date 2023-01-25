// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int InsertDigit(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[] InputArray (int number1)
{
    int [] array = new int [number1];
    for (int i = 0; i < number1; i++)
    {
        array[i] = InsertDigit($"введите {i+1} элемент массива");
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

int CountPossitiveDigits (int[] array2)
{int sum = 0;
for (int i = 0; i < array2.Length; i++)
{
    sum = array2[i]> 0 ? sum+1: sum;
}
return sum;
}


int num = InsertDigit ("введите количество элементов массива");
int [] arr = InputArray (num);
PrintArray(arr);
int result = CountPossitiveDigits (arr);
Console.WriteLine($"количество элементов массива больше 0 = {result}");

// string str = "3,5,6,5,8,-4";
// string[] strArr = str.Split(',');

