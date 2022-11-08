// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
static void PositiveNumberInput(int value)
{
    Console.WriteLine($"Введите {value} чисел.");
    double[] arr = new double[value];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = double.Parse(Console.ReadLine());
    }
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    PrintInConsole(String.Join(",", arr));
    PrintInConsole($"Чисел больше нуля - {count}");
}


//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
static Point IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;

    if (k1 == k2 && b1 == b2)
    {
        PrintInConsole("Прямые совпадают.");
    }
    else if (k1 == k2)
    {
        PrintInConsole("Прямые параллельны.");
    }
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    }

    return new Point(x, y);
}

//Метод для вывода в консоль.

static void PrintInConsole<T>(T value)
{
    System.Console.WriteLine(value);
}


//Точка в декартовой системе координат.
struct Point
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
        Z = 0;
    }
    public Point(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

}
