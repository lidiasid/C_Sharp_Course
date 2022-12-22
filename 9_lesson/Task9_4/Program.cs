// Напишите программу, которая на вход принимает два числа А и В, и возводит число А в целую степень В с помощью рекурсии.

int Degre (int A, int B)
{
    if (B == 0)return 1;
    return Degre (A, B-1)*A;
}
System.Console.WriteLine(Degre(3,5));
