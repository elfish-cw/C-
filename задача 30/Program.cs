// Задача 30. Написать программу, которая выводит массив из 8 элементов, 
// заполненный случайными числами единицами и нулями.

int [] array = new int [8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);
}
for (int i = 0; i < array.Length; i++)
{ Console.Write(array[i]);
}
Console.WriteLine();
