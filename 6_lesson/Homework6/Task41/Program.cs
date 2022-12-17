// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.Write("Введите количество чисел: ");
int numberofnumbers = int.Parse(Console.ReadLine());
int [] numbers = new int [numberofnumbers];
int schet = 0;
for (int i = 0; i < numberofnumbers; i++)
{
    System.Console.WriteLine($"Введите число {i + 1}: ");
    int usernum = int.Parse(Console.ReadLine());
    numbers [i] = usernum;
    if (usernum > 0)
    {
        schet ++;
    }
    else 
    {
        schet = schet;
    }
}
System.Console.WriteLine("Количество положительных чисел: " + schet);




