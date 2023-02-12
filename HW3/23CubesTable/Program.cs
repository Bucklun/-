// Задача 23 - Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int entIntNum ()
{
    int x = 0;
    bool check = false;
    while (check==false)
    {
        Console.Write("Enter an integer number ");
        string? str = Console.ReadLine();
        check = int.TryParse(str, out x);
    }
    return x;
}
int a = entIntNum();

for (double i = 1; i <= a; i++)
{
    double cube = Math.Pow(i, 3);
    Console.WriteLine($"{i}^{3} = {cube}");
}