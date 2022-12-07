// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] ArrayNums(int size)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().NextDouble()* (53.44 + 10.34) - 10.34;
    return arr;
}

void NeChetNum(double[] new_arr)
{  
    double max = 0.0;
    for (int i = 0; i < new_arr.Length; i++)
    {
        if (new_arr[i] > max)
        {
            max = new_arr[i];
        }
        else
        {
            max = max;
        }
    }
    double min = max;
    for (int j = 0; j < new_arr.Length; j++)
    {
        if (new_arr[j] < min)
        {
            min = new_arr[j];
        }
        else
        {
            min = min;
        }
    }
    System.Console.WriteLine("Разница: " + (max - min));
}

double[] arr_1 = ArrayNums(int.Parse(Console.ReadLine()));
Print(arr_1);
NeChetNum(arr_1);