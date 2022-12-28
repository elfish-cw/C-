// на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100000 && number > 9999)
{
    if (number % 10 == number / 10000 && number / 10 % 10 == number / 1000 % 10)
        Console.WriteLine("число палиндром");
    else
    {
        Console.WriteLine("число НЕ палиндром");
    }

}
else
{
    Console.WriteLine("ввели неправильное число");
}