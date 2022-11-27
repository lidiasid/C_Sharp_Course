// Задача 2:Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int number = new Random().Next(100, 999);

System.Console.WriteLine(number);

string number_to_str = number.ToString();

string new_number = number_to_str.Remove(number_to_str.Length -2, 1);

System.Console.WriteLine(new_number);