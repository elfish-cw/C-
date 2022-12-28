// Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите цифру дня недели (1-7): ");
int number = Convert.ToInt32(Console.ReadLine());


if (number == 1) Console.WriteLine("понедельник");
if (number == 2) Console.WriteLine("вторник");
if (number == 3) Console.WriteLine("среда");
if (number == 4) Console.WriteLine("четверг");
if (number == 5) Console.WriteLine("пятница");
if (number == 6) Console.WriteLine("суббота");
if (number == 7) Console.WriteLine("воскресение");
if (number < 0 || number > 7) Console.WriteLine("Вы ввели неверное значение");



