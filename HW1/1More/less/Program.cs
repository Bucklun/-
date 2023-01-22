// See https://aka.ms/new-console-template for more information
int a, b;

Console.WriteLine("Input integer number");
string? num1 = Console.ReadLine();
Console.WriteLine(int.TryParse(num1, out a));

Console.WriteLine("...and one more");
string? num2 = Console.ReadLine();
Console.WriteLine(int.TryParse(num2, out b));

if (a > b) Console.WriteLine(a + " > " + b);
else Console.WriteLine(b + " > " + a);


