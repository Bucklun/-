int a, n;
Console.WriteLine("Input number");
string? num = Console.ReadLine();
Console.WriteLine(int.TryParse(num, out a));

n = 2;

Console.WriteLine("Here we got: ");
while (n < a) 
{
    Console.Write( n + ", ");
    n = n + 2;
}