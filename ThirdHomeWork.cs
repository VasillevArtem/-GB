//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
static void IsPalindrom(int number)
{
    int tempS = 0;
    int tempE = number;
    int count = DigitsInTheNumber(number);
    if (count == 5)
    {
        while (number > 0)
        {
            tempS = tempS * 10 + number % 10;
            number = number / 10;
        }
        if (tempS == tempE)
        {
            PrintInConsole("This is palindrome.");
        }
        else
        {
            PrintInConsole("This is not palindrome.");
        }
    }
    else
    {
        PrintInConsole("Enter a five-digit number.");
    }
}


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
static void Distance(Point pointA, Point pointB) => PrintInConsole(Math.Sqrt(Math.Pow(pointB.X - pointA.X, 2) +
                                                                             Math.Pow((pointB.Y - pointA.Y), 2) +
                                                                             Math.Pow((pointB.Z - pointA.Z), 2)));


//Точка в декартовой системе координат.
struct Point
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
static void CubeNumber(int number)
{
    for (int i = 0; i < number; i++)
    {
        PrintInConsole($"{i * i * i} ");
    }
}



//Метод для подсчета количества цифр в числе.
static int DigitsInTheNumber(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number /= 10;
    }
    return count;
}


//Метод для вывода в консоль.
static void PrintInConsole<T>(T value)
{
    System.Console.WriteLine(value);
}
