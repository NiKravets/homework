// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int N = Prompt("Введите число => ");

int A = 1;
Console.Write(A + " ");
while (A <= N)
{
    A = A + 1;
    Console.Write(A*A*A + " ");
}