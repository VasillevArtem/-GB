//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

static void CompareTwoValues(int inputValueA, int inputValueB)
{   
    if(inputValueA == inputValueB)
    {
        System.Console.WriteLine($"Числа равны | {inputValueA} = {inputValueB}");
    }
    else if(inputValueA < inputValueB)
    {
        System.Console.WriteLine($"Число \"a\" меньше числа \"b\" | {inputValueA} < {inputValueB}");
    }
    else
    {
        System.Console.WriteLine($"Число \"a\" больше числа \"b\" | {inputValueA} > {inputValueB}");
    }
}


//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

static void CompareThreeValues(int inputValueA, int inputValueB, int inputValueC)
{   
    int maxValue = inputValueA;

    if(inputValueA == inputValueB && inputValueB == inputValueC) 
    {
        System.Console.WriteLine($"Числа равны | {inputValueA} = {inputValueB} = {inputValueC}");
    }else if(inputValueB > maxValue)
    {
        maxValue = inputValueB;
    }
    else if(inputValueC > maxValue)
    {
        maxValue = inputValueC;
    }
    System.Console.WriteLine($"Наибольшее число {maxValue}");
   
}


//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

static void IsTheEvenNumber(int num)
{
    if(num % 2 == 0)
    {
        System.Console.WriteLine($"Число {num} - четное");
    }
    else
    {
        System.Console.WriteLine($"Число {num} - не четное");
    }
}


//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

static void IsTheEvenNumberTo(int num)
{
    for (int i = 0; i <= num; i++)
    {
        if(i % 2 == 0)
        {
            System.Console.Write($"{i} ");
        }       
    }    
}
CompareThreeValues(1,2,2);