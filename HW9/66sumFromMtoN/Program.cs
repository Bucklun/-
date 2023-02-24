// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

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

int NumbersFromBeginingToEnd(int beginig, int end)
{
    if (beginig <= end)
    {
        if (beginig == end) return beginig;
        else return beginig + NumbersFromBeginingToEnd(beginig + 1, end);
    }
    else return end + NumbersFromBeginingToEnd(end + 1, beginig);
}

int M = EnterNumber("Enter M-number (first)");
int N = EnterNumber("Enter N-number (last)");

Console.WriteLine($"Summ of integer numbers between M and N will be {NumbersFromBeginingToEnd(M,N)}");