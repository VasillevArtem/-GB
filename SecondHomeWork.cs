//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

static void SecondDigit(int number)
{
    int result = 0;
    int count = DigitsInTheNumber(number);

    if (count == 3)
    {
        result = (number / 10) % 10;
        PrintInConsole(result);
    }
    else
    {
        PrintInConsole("Need a three digit number");
    }
}



//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

static void ThirdDigit(int number)
{
    int result = 0;
    int count = DigitsInTheNumber(number);
    if (count >= 3)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
        PrintInConsole(result);
    }
    else
    {
        PrintInConsole("The third digit is missing");
    }
    
}



//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

static void DayOfWeek(int numberDayOfWeek)
{    
    if(numberDayOfWeek > 0 && numberDayOfWeek <= 7)
    {
        if(numberDayOfWeek == 6 || numberDayOfWeek == 7)
        {
            PrintInConsole("This day is a weekend");
        }
        else
        {
            PrintInConsole("This day is not a weekend");
        }
        
    }
    else
    {
        PrintInConsole("Enter a number from 1 to 7");
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



