// Задача 69. Напишите программу, которая на вход
// принимает два числа Аи В, и возводит число А
// в целую степень В с помощью рекурсии.
// А=3, В=5 -> 243
// A=2, B=3 -> 8

Console.WriteLine("Введите натуральное число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натураьное число B");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumberDegree(numberA, numberB));

int NumberDegree(int numA, int numB)
{
    if (numB == 1) return numA;
    return numA * NumberDegree(numA, numB - 1);
}

