// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
        arr[i] = new Random().Next(1, 10);
    return arr;
}

void NeChetNum(int[] new_arr)
{  
    int j = 0;
    for (int i = 0; i < new_arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            j = j + new_arr[i];
        }
        else
        {
            j = j;
        }
    }
    System.Console.WriteLine("Сумма нечетных чисел: "+ j);
}

int[] arr_1 = ArrayNums(int.Parse(Console.ReadLine()));
Print(arr_1);
NeChetNum(arr_1);
