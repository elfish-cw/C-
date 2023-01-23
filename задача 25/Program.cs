// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int InsertDigit(string text)
{
    Console.WriteLine(text);

    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int num1 = InsertDigit("введите число");
int num2 = InsertDigit("введите степень числа");

int result = num1;
for (int i = 1; i < num2; i++)
{
    result *= num1;
}


Console.WriteLine($"=>{result}");



