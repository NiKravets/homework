// Задача 2: Проверка на простое число:
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
int N = Prompt("Введите число =>");
bool prost = true;
for (int i = 2; i <= Math.Sqrt(N); i++)
{
    if (N % i == 0)
    {
        prost = false;
        break;
    }
}
if (prost) Console.WriteLine("Это простое число");
else Console.WriteLine("Это не простое число");