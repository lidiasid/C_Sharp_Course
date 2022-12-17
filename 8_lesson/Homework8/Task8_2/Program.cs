// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],2} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(0, 10);

    return arr;
}

void MinStr(int[,] arr)
{
    int Sum = 0, Sum1 = 0, Sum2 = 0, Row = 0;

    for (int i = 0; i < arr.GetLength(0) ; i++)
    {
        Sum2 = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        { Sum2 += arr[i, j]; }
        if (Sum2 < Sum1)
        { Sum = Sum2; Row = i; }
        Sum1 = Sum2;
    }
    Console.WriteLine("Номер строки = {0}", Row + 1);
}

int[,] arr_1 = MassNums(3, 3);
Print(arr_1);
MinStr(arr_1);