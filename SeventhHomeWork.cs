//Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
static double[,] RandomValueArr(int row, int column, Random rand)
{
    double[,] arr = new double[row, column];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = RandomDouble(rand);
        }
    }
    return arr;
}


//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
static double ValueOfArray(double[,] arr, int row, int column)
{
    if (row < 0 || row >= arr.GetLength(0) || column < 0 || column >= arr.GetLength(1))
    {
        throw new ArgumentException("Выход за пределы массива.");
    }
    else
    {
        return arr[row, column];
    }

}



//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Метод для инициализации массива.
static int[,] CreateArr(int row, int column)
{
    Console.WriteLine($"Введите значение для текущей ячейки двумерного массива.");

    int[,] arr = new int[row, column];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = int.Parse(Console.ReadLine());

        }
    }
    return arr;
}

//Среднее арифметическое для столбца.
static double[] ArithmeticMean(int[,] arr)
{
    double[] resultArr = new double[arr.GetLength(0)];
    double temp = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            temp += arr[i, j];
        }

        temp = temp / arr.GetLength(1);
        resultArr[i] = Math.Round(temp, 2);
    }
    return resultArr;
}

//Метод для генерации случайных вещественных чисел.
static double RandomDouble(Random random)
{
    double mantissa = (random.NextDouble() * 2.0) - 1.0; 
    double exponent = Math.Pow(2.0, random.Next(-126, 128));
    return mantissa * exponent;
}
