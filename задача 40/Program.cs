﻿// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите 3 числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) Console.WriteLine("Да");
else System.Console.WriteLine("Нет");


/ Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


int side1 = NumberInput("Please, input your number 1");
int side2 = NumberInput("Please, input your number 2");
int side3 = NumberInput("Please, input your number 3");
Console.WriteLine(ExistTriangle(side1, side2, side3) ? "Triangle Exist" : "Triangle Does not exist");

int NumberInput(string text) // Method fot Number input
{
    Console.WriteLine(text);
    int numberinput = Convert.ToInt32(Console.ReadLine());
    return numberinput;
}

bool ExistTriangle(int s1, int s2, int s3)
{
    return s1 < s2 + s3 && s2 < s1 + s3 && s3 < s2 + s1;
}