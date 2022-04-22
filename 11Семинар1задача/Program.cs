// Задача 1: Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
bool step(int N) 
{
    if (N == 2) return true;
    else if (N% 2 == 0) return step(N / 2);
    else return false;
}
int N = Prompt("Введите число =>");
if (step(N)) Console.WriteLine("Является степень двойки");
else Console.WriteLine("Не является степенью двойки");


 


