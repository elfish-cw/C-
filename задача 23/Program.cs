// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index <= number)
{
    Console.WriteLine($"{index} | {index * index * index}");
    index++;
}
