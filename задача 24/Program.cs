// // Задача 24. Напишите программу, которая принимает
// на вход число (А) и выдает сумму чисел от 1 до А.
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

// int sumnumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {SumNumbers(number)}");
int SumNumbers (int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
        
//         sum = sum + i;
//     }
//     return sum;
// }

{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num;
        num -= 1;
    }
    return sum;
}

