// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
string strValue = Console.ReadLine();
int N = int.Parse(strValue);

int A = 2;
Console.Write(A + " ");
while (A < N)
{
    A = A + 1;
    if(A % 2 == 0)
    Console.Write(A + " ");
}
