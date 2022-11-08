//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
static void SumOdd()
{
    Random random = new Random();
    int[] array = new int[random.Next(10, 100)];
    int sumOdd = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
        if (i % 2 != 0)
        {
            sumOdd += array[i];
        }
    }
    PrintInConsole(sumOdd);
}


//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
static void SumBetweenMaxAndMin()
{
    Random random = new Random();
    double[] array = new double[random.Next(10, 100)];
    double sumOdd = 0;
     

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = RandomDouble(random);
    }
    sumOdd = array.Max() - array.Min();
    PrintInConsole(sumOdd);

}

//Метод для генерации случайных вещественных чисел.
static double RandomDouble(Random random)
{
    double mantissa = (random.NextDouble() * 2.0) - 1.0;    
    double exponent = Math.Pow(2.0, random.Next(-126, 128));
    return (mantissa * exponent);
}


//Метод для печати в консоль.
static void PrintInConsole<T>(T value)
{
    System.Console.WriteLine(value);
}
