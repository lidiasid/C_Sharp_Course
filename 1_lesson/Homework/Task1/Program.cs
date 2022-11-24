// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("max = " + number1 );
    Console.WriteLine("min = " + number2 );
}
else if (number1 < number2)
{
    Console.WriteLine("max = " + number2);
    Console.WriteLine("min = " + number1 );
}
else
{
    Console.WriteLine("The numbers are equal");
}
