//Задача 19 - Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int entIntNum ()
{
    int x = 0;
    bool check = false;
    while (check==false)
    {
        Console.WriteLine("Enter your number");
        string? str = Console.ReadLine();
        check = int.TryParse(str, out x);
    }
    return x;
}

int a = entIntNum();
string number = a.ToString();
int length = number.Length;
int unmach = 0;

for (int i = 0; i <= length/2; i++)
{
    int j = (length - 1) - i;
    if (number[i] - number[j] != 0) 
    {
        Console.WriteLine("Entered numder is NOT a palindrome");
        unmach++;
        break;
    }
}
if (unmach == 0) Console.WriteLine("Entered number is a palindrom");