// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int number3 = int.Parse(Console.ReadLine());

int [] numbers = {number1, number2, number3};

Console.WriteLine("Максимальное значение:" + numbers.Max());
