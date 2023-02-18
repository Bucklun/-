// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//            y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int EntNum(string wtf)
{
    int x = 0;
    Console.WriteLine(wtf);
    try
    {
        x = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.Write("Nope");
        x = EntNum(wtf);
    }
    return x;
}

Console.WriteLine("The equation of a line has the form y = kx + b, the programm find the point of intersection of two lines");

int k1 = EntNum("Enter the k-coefficient of a first line");
int b1 = EntNum("Enter the b-coefficient of a first line");
int k2 = EntNum("Enter the k-coefficient of a second line");
int b2 = EntNum("Enter the b-coefficient of a second line");

if (k1 == k2)
{
    if (b1 == b2) 
    {
        Console.WriteLine("The lines are match");
        return;
    }
    Console.WriteLine("The lines are parallel");
    return;
}
    double x = (b2 - b1) / (k1 - k2);
    x = Math.Round(x,2);

    double y = k1*x + b1;
    y = Math.Round(y,2);

    Console.WriteLine($"Lines, that you set, have a common point with coordinates ({x};{y})");