int a;
Console.WriteLine("Input number for check");
string? num = Console.ReadLine();
Console.WriteLine(int.TryParse(num, out a));

if (a % 2 == 0) Console.WriteLine(a + " - even number");

else Console.WriteLine(a + " - uneven number");
