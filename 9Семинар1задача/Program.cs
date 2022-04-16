// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
void PrintEven(int N, int M)
{
    if (M > N) return;
    if (M % 2 == 0)
        Console.Write(M + " ");
    PrintEven(N, M + 1);
}
int M = Prompt("Введите число => ");
int N = Prompt("Введите число => ");
PrintEven(N, M);