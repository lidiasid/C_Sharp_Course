System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
string num1 = number.ToString();
int result = 0;

for (int i = 0; i < num1.Length; i++)
{
    result = result + num1[i];
    System.Console.WriteLine(result);
}

System.Console.WriteLine(result);
