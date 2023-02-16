// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//            Напишите программу, которая покажет количество чётных чисел в массиве.

void fillArray(int[] array)
{
    Random ran = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ran.Next(100,1000);
    }
} 

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int[] array = new int[12];

fillArray(array);
printArray(array);

int count = 0;

foreach (var item in array)
{
    if (item%2 == 0) count++;
}
Console.Write($"This array contein {count} even numbers");
