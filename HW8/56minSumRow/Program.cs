// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
int m = ran.Next(2,10);
int n = ran.Next(2,10);

int[,] array = new int[m,n];

fill2DArray(array);
print2DArray(array);

int[] summ = new int[m];

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }
    
    summ[i] = sum;
}

foreach (var item in summ)
{
    Console.Write(item + "|");
}
Console.WriteLine();

int min = summ[0];
int minRow = 1;
for (int i = 1; i < summ.Length; i++)
{
    if (summ[i] < min) 
    {   
        min = summ[i];
        minRow = i+1;
    }
}
Console.WriteLine($"Less sum of the row elements ({min}) is in {minRow} row");