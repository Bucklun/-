// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//            и возвращает значение этого элемента или же указание, что такого элемента нет.

void fill2DArray(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(-100,100);
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

Random ran = new Random();
int m = ran.Next(1,10);
int n = ran.Next(1,10);
int[,] array = new int[m,n];

fill2DArray(array);
Console.WriteLine($"There is an arrey whith {m} rows and {n} columns");

int r = EntNum("What row-index is interesting for us (numbering from 0)?");
if (r >= array.GetLength(0)) 
{
    Console.WriteLine("The element with such index isn't exist");
    return;
}
int c = EntNum("What the index of column (numbering from 0)?..");
if (c >= array.GetLength(1))
{
    Console.WriteLine("The element with such index isn't exist");
    return; 
}

Console.WriteLine($"Element with index [{r},{c}] is {array[r,c]}");
print2DArray(array);
