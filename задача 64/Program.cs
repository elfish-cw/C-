// // Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());
NaturalNumber(numberN);
Console.WriteLine();



void NaturalNumber(int numN)
{
    if (numN == 0)
        return;

    if (numN > 0)
    {
        Console.Write($"{numN} ");
        NaturalNumber(numN - 1);
    }

    else
    {
        Console.Write($"{numN} ");
        NaturalNumber(numN + 1);
    }
}

