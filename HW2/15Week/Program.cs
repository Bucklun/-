int day = 0;
while ((day < 1) || (day > 7)) 
{
    Console.WriteLine("Enter an integer number, which will correspond to certain day of a week");
    string? num = Console.ReadLine();
    int.TryParse(num, out day);
}

if(day < 6) Console.WriteLine("No - it's a working day");
else Console.WriteLine("Yes - it's a weekend");

// switch(day)

// {
//     case 1:
//     Console.WriteLine("No - it's a working day");
//     break;

//     case 2:
//     Console.WriteLine("No - it's a working day");
//     break;

//     case 3:
//     Console.WriteLine("No - it's a working day");
//     break;

//     case 4:
//     Console.WriteLine("No - it's a working day");
//     break;

//     case 5:
//     Console.WriteLine("No - it's a working day");
//     break;

//     case 6:
//     Console.WriteLine("Yes - it's (finaly) weekend");
//     break;

//     case 7:
//     Console.WriteLine("Yes - it's (finaly) weekend");
//     break;
// }