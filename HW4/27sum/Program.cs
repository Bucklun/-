// Задача 27 - Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
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

int a = entIntNum("Enter your number: ");
int temp = Math.Abs(a);
int length = temp.ToString().Length;
int sum = 0;

for(int i = 0; i < length; i++)
{
    int remains = temp % 10;
    sum += remains;
    
    if (i == (length - 1)) Console.Write(remains);
    else 
    {   Console.Write($"{remains} + ");
        temp = temp / 10;
    }
}
Console.Write($" = {sum}");