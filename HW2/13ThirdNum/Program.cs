int EntNum()
{
    int a = 0;
    Console.WriteLine("Enter an integer number");
    string? num = Console.ReadLine();
    int.TryParse(num, out a);
    return a;
}

int digit = EntNum();
int digitOp = digit;
int count = 1;
while (digitOp > 10) 
{
    digitOp = digitOp / 10;
    count = count + 1;
}

if (count < 3) Console.WriteLine("There is no third digit");
else 
{
    double power10 = Math.Pow(10, (count - 3));

    int third = (digit / Convert.ToInt32(power10)) % 10;  
   
    Console.WriteLine("Third digit is " + third);
}
