// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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

int[,] ArrayMultiply(int[,] arr_1, int[,] arr_2)
{
    var res = new int[arr_1.GetLength(0), arr_2.GetLength(1)];
    for (var i = 0; i < arr_1.GetLength(0); i++)
    {
        for (var j = 0; j < arr_2.GetLength(1); j++)
        {
            res[i, j] = 0;
            for (var k = 0; k < arr_1.GetLength(1); k++)
            {
                res[i, j] += arr_1[i, k] * arr_2[k, j];
            }
        }
    }
    return res;
}

int[,] arr_1 = MassNums(2, 2);
int[,] arr_2 = MassNums(2, 2);
Print(arr_1);
Print(arr_2);
int[,] arr_res = ArrayMultiply(arr_1, arr_2);
Print(arr_res);