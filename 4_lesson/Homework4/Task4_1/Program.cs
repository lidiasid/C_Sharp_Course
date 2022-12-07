//  Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Без модуля Math, используем цикл for.

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число:");
int power = int.Parse(Console.ReadLine());

int result = number;
for (int i = 1; i < power; i++)
{
    result = result * number;
}

System.Console.WriteLine(result);
