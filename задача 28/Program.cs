// Задача 28. Принимаем на вход число N 
// выдаем его факториал.
// 4 -> 24
// 5 -> 120


int InsertDigit(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Factorial(int num)
{int result = 1;
for (int i = 1; i <= num; i++)
{
result = result * i;

}
return result;
}
int insertNum = InsertDigit("введите число:");

Console.WriteLine($"факториал числа {insertNum} = {Factorial(insertNum)}");
