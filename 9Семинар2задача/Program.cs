// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
int Sum(int A, int B)
{
    if (B == A) return A;
    return A + Sum(A + 1, B);

}
int M = Prompt("Введите число => ");
int N = Prompt("Введите число => ");
Console.WriteLine(Sum(M, N));