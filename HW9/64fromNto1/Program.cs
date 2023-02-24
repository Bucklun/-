// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int EnterNumber(string annotation)
{
    int x;
    Console.WriteLine(annotation);
    try
    {
        x = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("It's not an integer number, try again");
        x = EnterNumber(annotation);
    }
    return x;
}

string NumbersRowFromGiven(int given)
{
    if (given == 0) return "";
    else 
    {
        return $"{given} " + NumbersRowFromGiven(given - 1);
    }
}

int N = EnterNumber("Enter the begining number");

Console.WriteLine(NumbersRowFromGiven(N));