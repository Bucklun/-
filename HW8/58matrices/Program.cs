// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void fill2DArray(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(10);
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
int m = ran.Next(2,6);
int n = ran.Next(2,6);
int k = ran.Next(2,6);

int[,] first = new int[m,n];
fill2DArray(first);
print2DArray(first);

int[,] second = new int[n,k];
fill2DArray(second);
print2DArray(second);

int[,] product = new int[m,k];

for (int i = 0; i < product.GetLength(0); i++)
{
    for (int j = 0; j < product.GetLength(1); j++)
    {
        int sum = 0;
        for (int c = 0; c < first.GetLength(1); c++ )
        {
            sum = sum + first[i,c] * second[c,j];
        }
        product[i,j] = sum;
    }
}
print2DArray(product);                      //м-м-да... третий цикл не дался https://habr.com/ru/post/359272/