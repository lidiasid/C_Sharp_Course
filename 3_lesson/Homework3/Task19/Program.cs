// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

System.Console.WriteLine("Введите пятизначное число: ");

int number = int.Parse(Console.ReadLine());
string num1 = number.ToString();
string num2 = String.Empty;
for (int i = num1.Length - 1; i >= 0; i--)
{
    num2 = num2 + num1[i];
}
if (num2 == num1)
{
    System.Console.WriteLine("Число " + num1 + " является полиндромом");
}
else
{
    System.Console.WriteLine("Число " + num1 + " не является полиндромом");
}