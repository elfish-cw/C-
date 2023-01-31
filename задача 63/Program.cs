// Задача 63. Задайте значение N. Напишите программу,
// которая выведет все натуральные числа
// в промежутке от 1- N.
// N = 5 -> 1,2,3,4,5
Console.WriteLine ("введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNumber(number);

void NaturalNumber(int num)
{
    if (num == 0) return;
   NaturalNumber(num-1);
   Console.Write($"{num}");
 }
