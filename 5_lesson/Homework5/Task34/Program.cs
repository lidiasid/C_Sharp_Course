// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] ArrayNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(100, 999);
    return arr;
}

void ChetNum(int[] chet_arr)
{  
    int j = 0;
    for (int i = 0; i < chet_arr.Length; i++)
    {
        if (chet_arr[i] % 2 == 0)
        {
            j++;
        }
        else
        {
            j = j;
        }
    }
    System.Console.WriteLine("Количество четных чисел: "+ j);
}

int[] arr_1 = ArrayNums(int.Parse(Console.ReadLine()));
Print(arr_1);
ChetNum(arr_1);
