//Задача 4:Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели:");
int number = int.Parse(Console.ReadLine());

if ( number == 6 || number == 7) 
{
    Console.WriteLine("Выходной");
}
    else
{
    Console.WriteLine("Не выходной");
}
