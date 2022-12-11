// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

System.Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int result = 0;

for (int i = 0; i < number.Length; i++)
{
    int num2 = (int)Char.GetNumericValue(number[i]);
    result = result + num2;
}

System.Console.WriteLine(result);




