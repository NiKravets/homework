// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число 1: ");
string strValue1 = Console.ReadLine();
int Value1 = int.Parse(strValue1);

Console.Write("Введите число 2: ");
string strValue2 = Console.ReadLine();
int Value2 = int.Parse(strValue2);

Console.Write("Введите число 3: ");
string strValue3 = Console.ReadLine();
int Value3 = int.Parse(strValue3);

int max = Value1;

if(Value1 > max) max = Value1;
if(Value2 > max) max = Value2;
if(Value3 > max) max = Value3;
Console.Write("max = " + max);

