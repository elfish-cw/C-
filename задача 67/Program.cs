// Задача 67.Напишите программу,
// которая будет принимать на вход число М
// возвратить сумму его цифр.

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{SumNumber(number)}");

int SumNumber(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumNumber(num / 10);
}



// {
//     insertNum = Math.Abs(insertNum);
//     int sum = 0;
//  while (insertNum>0)
//  {
//  sum = sum+insertNum%10;
//  insertNum = insertNum/10;
//  }
//  return sum;
// }