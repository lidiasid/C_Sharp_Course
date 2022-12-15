// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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
            arr[i, j] = new Random().Next(0, 100);

    return arr;
}

System.Console.WriteLine("Укажите позицию по горизонтали: ");
int posx = int.Parse(Console.ReadLine());
System.Console.WriteLine("Укажите позицию по вертиали: ");
int posy = int.Parse(Console.ReadLine());

string FindElem(int[,] arr, int posx, int posy)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (i == posy && j == posx)
                return $"Значение заданной позиции: {arr[i,j]}";
    return $"Искомый элемент не найден";
}

int[,] arr_1 = MassNums(10, 10);
Console.WriteLine(FindElem(arr_1, posx, posy));
Print(arr_1);
