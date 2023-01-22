int a, b, c;
Console.WriteLine("You should input three integer numbers. First number ");
string? num1 = Console.ReadLine();
Console.WriteLine(int.TryParse(num1, out a));

Console.WriteLine("Second number ");
string? num2 = Console.ReadLine();
Console.WriteLine(int.TryParse(num2, out b));

Console.WriteLine("Third number ");
string? num3 = Console.ReadLine();
Console.WriteLine(int.TryParse(num3, out c));

if (b > a) a = b;

if (c > a) a = c;

Console.WriteLine(a + " is the biggest number at this time ");