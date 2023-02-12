//Задача 25 - Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int entIntNum (string wtf)
{
    int x = 0;
    bool check = false;
    while (check==false)
    {
        Console.Write(wtf);
        string? str = Console.ReadLine();
        check = int.TryParse(str, out x);
    }
    return x;
}

int A = entIntNum("Enter the base number: ");
int B = entIntNum("Enter the power for base number: ");

double Apow = 0;

if (B == 0) Apow = 1;
else if (B > 0)
{
    Apow = A;
    for (int i = 1; i < B; i++)
    {
        Apow = Apow * A;
    }
}
else if (B < 0)
{
    Apow = A;                           //Apow = 1 / A   почему-то, всегда равнялось нолю
    for (int i = (B - 1); i < 0; i++)
    {
        Apow = Apow / A;
    }
    Apow = Math.Round(Apow,3);
}
Console.WriteLine($"{A} ^ {B} = {Apow}");