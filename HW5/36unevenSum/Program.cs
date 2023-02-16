// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void fillArray (int[] array)
{
    Random ran = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ran.Next(-10, 11);
    }
}
void printArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

int[] array = new int[12];

fillArray(array);
printArray(array);

int sum = 0;
for (int i = 1; i < array.Length; i += 2)
{
    sum += array[i];
}
Console.Write($"Sum of all numbers, with have uneven index, is {sum}");