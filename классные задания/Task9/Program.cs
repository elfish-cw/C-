// Получить случайное число от 10-99
int number = new Random().Next(10,100);
Console.WriteLine($"Случайное число из диапозона 10-99 -> {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"наибольшая цифра числа {number} = {firstDigit}");
// else Console.WriteLine($"наибольшая цифра числа {number} = {secondDigit}");

// или тернарный оператор
// Console.WriteLine("наибольшая цифра числа = ");
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);


//решаем эту задачу МЕТОДОМ

int maxDigit = MaxDigit(number);
Console.WriteLine($"наибольшая цифра числа {number} = {maxDigit}");

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
return result;
}
    