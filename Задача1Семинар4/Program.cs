// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
int Number(int Value, int degree)
{
    int work = Value;
    for(int i = 1; i < degree; i++ )
    {
        work = work * Value;
    }
return work;
}
int A = Prompt("ВВедите число А => ");
int B = Prompt("ВВедите число B => ");
int C = Number(A, B);
Console.WriteLine($"{A},{B} => {C}");
