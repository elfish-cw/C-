// Задача 26. Напишите программу, которая принимает на вход число и выдает количество 
// цифр в числе
// 456 ->3


int InsertDigit(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


int CountDigit(int digit)
{
    digit = Math.Abs(digit);
    int sum = 0;
    while (digit > 0)
    {
        digit = digit / 10;
        sum++;
    }
    return sum;
}

int num = InsertDigit("введите число");
Console.WriteLine($"количество цифр в числе {num} = {CountDigit(num)}"); 
