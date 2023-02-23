// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

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

Random rnd = new Random();

int m = rnd.Next(3,10);
Console.WriteLine(m);

int[,] array = new int[m,m];
int count = 1;                                            //число-элемент массива

int i = 0;
int j = 0;

for (int decrement = 1; count < array.Length; decrement++)//декремент - граница перебора индексов для новых витков спирали.
{
    if (i >= decrement) 
    {
        for (; i > decrement - 1; i--)                   //вверх, если до того были внизу
        {
            array[i,j] = count;
            count++;
        }
    }
    
    for (; j < array.GetLength(0) - decrement; j++)      //вправо до предпоследнего
    {
        array[i,j] = count;
        count++;
    }

    for (; i < array.GetLength(0) - decrement; i++)     //вниз
    {
        array[i,j] = count;
        count++;
    }

    for (; j > decrement - 1; j--)                      //влево
    {
        array[i,j] = count;
        count++;
    }
}
array[i,j] = count;                                     //костыль

print2DArray(array); 