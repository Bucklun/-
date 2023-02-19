// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void fill2DArray(double[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            double a = rnd.NextDouble();
            int b = rnd.Next(-100,100);
            arr[i,j] = Math.Round((a * b),2);
        }

    }
}
void print2DArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}
int EntNum(string wtf)
{
    int x = 0;
    Console.WriteLine(wtf);
    try
    {
        x = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Try again");
        x = EntNum(wtf);
    }
    return x;
}

int rows = EntNum("How mach rows we need?");
int columns = EntNum("...and how much columns?");

double[,] array = new double[rows,columns];
fill2DArray(array);
print2DArray(array); 
