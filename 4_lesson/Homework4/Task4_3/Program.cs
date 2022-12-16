// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];

for(int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(100);
    
}    
string str = string.Join(" ", array);
Console.WriteLine($"[{str}]");

/*void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] EightMass(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(1, 100);
    return arr;
}

int[] arr_1 = EightMass(int.Parse(Console.ReadLine()));
Print(arr_1);
int[] arr_2 = EightMass(int.Parse(Console.ReadLine()));
Print(arr_2);*/

