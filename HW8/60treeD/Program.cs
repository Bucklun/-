// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//            Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int rndUniqNum(int[] check)
{
    int x = new Random().Next(10,100);
    foreach (var item in check)
    {
        if (item == x) x = rndUniqNum(check);
    }
    return x;
}
void fill3DArray(int[,,] arr)
{
    Random rnd = new Random();
    
    int[] buyan = new int[arr.Length];

    int count = 0;
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {   
                arr[i,j,k] = rndUniqNum(buyan);
                buyan[count] = arr[i,j,k];
                count ++;
            }
        }
    }
}
void print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {   
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Random ran = new Random();
int x = ran.Next(2,6);
int y = ran.Next(2,6);
int z = ran.Next(2,6);

int[,,] array = new int[x,y,z];

fill3DArray(array);
print3DArray(array);