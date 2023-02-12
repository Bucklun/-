// Задача 21 - Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int entIntNum ()
{
    int x = 0;
    bool check = false;
    while (check==false)
    {
        Console.Write("(enter the coordinate) = ");
        string? str = Console.ReadLine();
        check = int.TryParse(str, out x);
    }
    return x;
}
Console.Write("Ax ");
int Ax = entIntNum();

Console.Write("Ay ");
int Ay = entIntNum();

Console.Write("Az ");
int Az = entIntNum();

Console.Write("Ax ");
int Bx = entIntNum();

Console.Write("Ax ");
int By = entIntNum();

Console.Write("Ax ");
int Bz = entIntNum();

double length = Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2) + Math.Pow((Bz - Az), 2));

length = Math.Round(length, 2);
Console.WriteLine("A distans between this point is " + length);