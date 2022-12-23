// принимаем на вход трехзначное число и на выходе показываем вторую цифру этого числа

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int second = SecondDigit(number);
    Console.WriteLine ($"вторая цифра этого числа = {second}");
    

}
else Console.WriteLine ("Вы ввели не трехзначное число");

int SecondDigit(int num)
{
    int secondDigit = num / 10 % 10; 
    return secondDigit;
}

