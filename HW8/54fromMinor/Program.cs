// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

 int temp;

for (int i = 0; i < array.GetLength(0); i++)
{   
    for (int j = 0; j < array.GetLength(1); j++)
    {   
        for (int k = 0; k < array.GetLength(1) - j; k++)
        {   
            if (array[i,j] < array[i,j + k])
            {
                temp = array[i,j];
                array[i,j] = array[i,j + k];
                array[i,j + k] = temp;
            }
        }
        
    }
}
print2DArray(array);