//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
static void DegOfNum(int value, int deg)
{
    int temp = 1;
    for (int i = 0; i < deg; i++)
    {
        temp *= value;
    }
    PrintInConsole(temp);
}


//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
static void SumDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    PrintInConsole(sum);
}



//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
static void RandomArray()
{
    Random random = new Random();
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100);
        PrintInConsole(array[i]);
    }
}

static void PrintInConsole<T>(T value)
{
    System.Console.WriteLine(value);
}