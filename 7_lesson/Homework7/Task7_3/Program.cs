// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(0, 50);

    return arr;
}

void Average(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double srAr = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            srAr += arr[j,i];
        }
        Console.Write($"{Math.Round(srAr/arr.GetLength(0))}; ");
    }
}

int[,] arr_1 = MassNums(3, 3);
Print(arr_1);
Average(arr_1);
