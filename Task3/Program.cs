﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine($"{number} - четное число");
} 
else 
Console.WriteLine($"{number} - нечетное число");
