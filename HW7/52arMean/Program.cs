// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void fill2DArray(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(100);
        }

    }
}
void print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Random ran = new Random();
int m = ran.Next(1,10);
int n = ran.Next(1,10);
int[,] array = new int[m,n];

fill2DArray(array);
Console.WriteLine($"There is an arrey whith {m} rows and {n} columns");
print2DArray(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i,j];
    }
    double resalt = sum / m;
    Console.WriteLine($"Arithmetic mean of a {j+1} column is {resalt}");
}
Console.WriteLine();
int totalSum = 0;
foreach (var item in array)
{
    totalSum += item; 
}
double totalResalt = totalSum / array.Length;
Console.WriteLine($"Arithmetic mean of whole array is {totalResalt}");