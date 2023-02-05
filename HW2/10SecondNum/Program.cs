int a = 0;
while((a < 100) || (a >= 1000))
{
    Console.WriteLine("Enter a three-digit integer");
    string? num = Console.ReadLine();
    int.TryParse(num, out a); 
}
int b = (a / 10) % 10;
Console.WriteLine($"Second digit in your number is {b}");
