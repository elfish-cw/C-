// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число  M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"сумма = {NaturalNumbers(numberM, numberN)}");


int NaturalNumbers(int numM, int numN)
{
    if (numN == numM)
    {
        // Console.Write($"{numM} ");
        return numN;
    }

    if (numM < numN)
    {
        // Console.Write($"{numM} ");
        NaturalNumbers(numM + 1, numN);
        return NaturalNumbers(numM + 1, numN) + numM;
    }
    else
    {
        // Console.Write($"{numM} ");
        NaturalNumbers(numM - 1, numN);
        return NaturalNumbers(numM - 1, numN) + numM;
    }

}

