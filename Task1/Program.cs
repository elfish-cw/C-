
Console.WriteLine("введите 2 числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"Число {num1} большее, число {num2} меньшее");
}
else
if (num1 < num2)
{
    Console.WriteLine($"Число {num2} большее, число {num1} меньшее");
}
else
    Console.WriteLine("Числа равны");

