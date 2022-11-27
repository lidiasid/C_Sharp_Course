// Задача 1:      Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите техзначное число:");
int number = int.Parse(Console.ReadLine());
string num2 = number.ToString();
Console.WriteLine(num2[1]);

