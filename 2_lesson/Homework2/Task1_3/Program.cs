// Задача 3:Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.WriteLine("Задайте число: ");

int number = int.Parse(Console.ReadLine());
string num2 = number.ToString();

if (num2.Length >= 3)
{
   Console.WriteLine(num2[2]); 
}
else
{
   Console.WriteLine("Третьей цифры нет."); 
}
