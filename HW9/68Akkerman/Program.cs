// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии для двух неотрицательных чисел m и n.

ulong EnterUnnegativeLongNumber(string annotation)
{
    ulong x;
    Console.WriteLine(annotation);
    try
    {
        x = Convert.ToUInt64(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("It's not a number, try again");
        x = EnterUnnegativeLongNumber(annotation);
    }
    x = x >= 0 ? x: EnterUnnegativeLongNumber(annotation);
    return x;
}

ulong AkkermanFunction(ulong m, ulong n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    else if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n -1));
    else return 0;
}

ulong m = EnterUnnegativeLongNumber("Enter m");
ulong n = EnterUnnegativeLongNumber("Enter n");

Console.WriteLine(AkkermanFunction(m , n));
