// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void fillArreyDouble(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double dob = rnd.NextDouble();
        int j = rnd.Next(0,3);

        dob = dob * Math.Pow(10,j) * Math.Pow(-1,j);
        
        array[i] = Math.Round(dob,2);
    }
}
void printArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double[] massive = new double[12];

fillArreyDouble(massive);
printArray(massive);

double max = 0;
double min = 0;

foreach (double var in massive)
{
    if (var > max) max = var;
    if (var < min) min = var;
}
Console.WriteLine("Maximal value is " + max);
Console.WriteLine("Least value is " + min);
double dif = Math.Round((max-min), 2);
Console.Write($"Difference between maximal and minimal numbers in array is {dif}");