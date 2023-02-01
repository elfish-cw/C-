// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите натуральное неотрицательное число A(меньше 4)");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA < 0 || numberA>4) Console.WriteLine("Ошибка ввода. Введите натуральное неотрицательное число A(меньше 4)");

Console.WriteLine("Введите натураьное число B");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB < 0 || numberB>4) 
Console.WriteLine("Ошибка ввода. Введите натуральное неотрицательное число В(меньше 4)");


Console.WriteLine(Akkerman(numberA, numberB));

int Akkerman(int numA, int numB)
{
    if (numA == 0) return numB+1;
    else if (numB == 0) return Akkerman(numA-1,1);
    return Akkerman(numA-1, Akkerman(numA, numB-1));
}
