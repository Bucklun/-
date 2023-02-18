// Задача 46 - Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int EnteringNum (string str)
{
    int x;
    Console.WriteLine(str);
    try
    {
        x = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Try again");
        x = EnteringNum(str);
    }
    return x;
}
int M = EnteringNum("How much numbers you want to enter?");

int[] storage = new int[M];

for (int i = 0; i < M; i++)
{
    storage[i] = EnteringNum($"{i+1} - Enter positive or negative integer number");
}

Console.WriteLine("Lets look, what we got: ");
int pos = 0;
foreach (var item in storage)
{
    Console.Write($"{item}|");
    if (item > 0) pos++;
}
Console.WriteLine();
Console.Write($"You had entered {pos} positive numbers");

