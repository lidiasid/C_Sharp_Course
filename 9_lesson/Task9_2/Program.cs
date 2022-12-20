// 2. Задайте значение M и N. Напишите программу, которая рекурсвно выведет все натуральные числа в промежутке от M до N.

void Numbers(int m, int n)
{
    if (m > n) return;
    System.Console.Write($" {m} ");
    Numbers(m+1, n);
}
Numbers(5,8);