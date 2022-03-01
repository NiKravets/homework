// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
string strValue = Console.ReadLine();
int Value = int.Parse(strValue);


if(Value % 2 == 0) 
{
    Console.Write("Число " + Value + " чётное");
}
else
{
    Console.Write("Число " + Value + " нечётное");
}
