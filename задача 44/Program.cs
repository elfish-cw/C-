// Задача 44. Не используя рекурсию, выведите первые N
// чисел Фибоначчи. Первые 2 числа Фибоначчи: 0,1.
// N=5 ->0 1 1 2 3
// N=3 ->0 1 1 
// N=7 ->0 1 1 2 3 5 8




int[] Fibonacci(int num)
{
    int[] fibo = new int[num];
    fibo[1] = 1;

    for (int i = 2; i < num;i++)
    {
        fibo[i] = fibo[i - 2] + fibo[i - 1]; 
    }
        return fibo;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write (array[i] + ", ");
        else Console.Write (array[i]);
    }
    Console.WriteLine("]");
}

int InputNum (string text) // Method fot Number input
{
    Console.WriteLine(text);
    int numberinput = Convert.ToInt32(Console.ReadLine());
    return numberinput;
}
int number = InputNum("введите N");
int[] fiboArray = Fibonacci(number);
PrintArray(fiboArray);
