// Задача 29 - Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int entIntNum (string wtf)
{
    int x = 0;
    bool check = false;
    while (check==false)
    {
        Console.Write(wtf);
        string? str = Console.ReadLine();
        check = int.TryParse(str, out x);
    }
    return x;
}
int rnd()
{
    int a = new Random().Next(8);
    return a;
}
bool checking(int x, int[] arra)        //Метод проверяет, есть ли случайный индекс в массиве "отработавших": true - его там нет
{
    bool resalt = true;
    for (int i = 0; i < arra.Length; i++)
    {
        if (arra[i] == x) 
        {   
            resalt = false;
            break; 
        } 
    }
    return resalt;
}

int[] array = new int [8];

int[] ix = {8,8,8,8,8,8,8,8};           //Массив для хранения "отработавших" индексов

int i = 0;
while (i < 8)
{
    int index = rnd();
    // Console.Write($" {i} ");
    // Console.Write(index);
    // Console.WriteLine();
    bool check = checking(index, ix);
    if (check == true) 
    {
        array[index] = entIntNum("Enter an integer number for the array: ");
        ix[i] = index;
        i++;
    } 
}
Console.WriteLine();
Console.Write("Array, that we deserve: ");
for (int j = 0; j < 8; j++)
{
    if (j < 7) Console.Write($"{array[j]}, ");
    else Console.Write($"{array[j]}");
}
        