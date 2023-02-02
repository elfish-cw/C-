// Задача 43.
// Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



int NumberInput(string text) // Method fot Number input
{
    Console.WriteLine(text);
    int numberinput = Convert.ToInt32(Console.ReadLine());
    return numberinput;
}

double [] Intersection(double numB1, double numK1, double numB2, double numK2)
{
    double [] array = new double [2];
    array [0] = (numB2-numB1)/(numK1-numK2);
    array [1] = (numK1*numB2 - numB1*numK2)/(numK1 - numK2);
    return array; 
}


// void PrintArray(double[] array1)
// {
//     Console.Write("[");
//     for (int i = 0; i < array1.Length; i++)
//     {
//         if (i < array1.Length - 1) Console.Write($"{array1[i]}, ");
//         else Console.Write($"{array1[i]}]");
//     }
//     Console.WriteLine();}


double numberB1 = NumberInput("Please, input your number b1");
double numberK1 = NumberInput("Please, input your number k1");
double numberB2 = NumberInput("Please, input your number b2");
double numberK2 = NumberInput("Please, input your number k1");
double [] arr = Intersection(numberB1,numberK1,numberB2,numberK2);
Console.WriteLine ($"( {arr [0]}, {arr [1]} )");
// PrintArray(Intersection(numberB1,numberK1,numberB2,numberK2));
