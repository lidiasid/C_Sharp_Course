// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Sum(int n, int m)
{
    if(n > m)
        return 0;
    return n + Sum(n+1, m);
}
System.Console.WriteLine(Sum(1,15));