// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InsertDigit(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumDigits (int insertNum)
{
    insertNum = Math.Abs(insertNum);
    int sum = 0;
 while (insertNum>0)
 {
 sum = sum+insertNum%10;
 insertNum = insertNum/10;
 }
 return sum;
}
int num = InsertDigit("введите число:");
Console.WriteLine($"в числе {num} сумма цифр = {SumDigits(num)}");

