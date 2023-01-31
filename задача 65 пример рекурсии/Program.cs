// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите натураьное число  M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натураьное число N");
int numberN = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(numberM, numberN);


void NaturalNumbers(int numM, int numN)
{
    if (numN == numM)
    {
        Console.Write($"{numN} ");
        return;
    }
    if (numM < numN)
    {Console.Write($"{numM} ");
        NaturalNumbers(numM + 1, numN);}
    else
    {Console.Write($"{numM} ");
        NaturalNumbers(numM - 1, numN);}
        
//    if (numN > numM)
//         NaturalNumbers(numM, numN-1);
//     else
//         NaturalNumbers(numM, numN+1);  
//         Console.Write($"{numN} "); 
    
}


// вот таким образом не знаю как решать

// void NaturalNumbers(int numM, int numN)
// {
// if (numM <= numN) 
// {Console.Write($"{numM}");
// NaturalNumbers(numM+1,numN);}

// с условия else перестает работать
// else if (numN <= numM) 
// {Console.Write($"{numN}");
// NaturalNumbers(numM,numN+1);}
// }


// решение в классе с sign

// Console.WriteLine("Please, enter number N");
// int numberN = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please, enter number M");
// int numberM = Convert.ToInt32(Console.ReadLine());

// while (numberN == numberM)
// {
//     Console.WriteLine("Your numbers are equal! Please, reenter neumber M");
//     numberM = Convert.ToInt32(Console.ReadLine());
// }

// int sign = Math.Sign((numberN - numberM));

// NaturalNumbers(numberN, numberM);

// void NaturalNumbers(int numN, int numM)
// {
//     Console.Write($"{numN} ");
//     if (numN == numM) return;
//     NaturalNumbers(numN - 1 * sign, numM);
// }



// ИЛИ



// int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
// {
//     int result; bool parse;
//     Console.WriteLine(text);
//     parse = Int32.TryParse(Console.ReadLine(), out result);
//     if (!parse) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
//     return result;
// }


// void IntegerNumbers(int n, int m, int s)
// {
//     if (n == m)
//     {
//         Console.Write($"{n} ");
//         return;
//     }
//     IntegerNumbers(n + s, m, s);

//     Console.Write($"{n} ");
// }

// int mUser = InsertDigit("Введите число N:");
// int nUser = InsertDigit("Введите число M:");

// int sign=Math.Sign((mUser-nUser));
// Console.WriteLine($"sign = {sign}");

// IntegerNumbers(nUser, mUser, sign);