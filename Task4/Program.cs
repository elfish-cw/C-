// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите положительное целое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("нет четных чисел в диапозоне до введенного числа");
}
while (number > 1)
{
    {
        if (number % 2 == 0)

        { Console.WriteLine($"{number}"); }
    }

    number = (number - 1);
}


