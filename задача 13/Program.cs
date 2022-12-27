// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите целое число, в котором мы будем искать третью цифру :");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
      number = number * (-1);
      }
if (number > 99)
{
      while (number / 10 > 99)
    
{
      number = number / 10;
}
int thirdDigit = number % 10;
Console.WriteLine($"третья цифра слева числа = {thirdDigit}");

}

else Console.WriteLine ("данное число не имеет третьей цифры");

