// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число: ");
string strValue = Console.ReadLine();
int Value = int.Parse(strValue);

if(Value == 6 || Value == 7) Console.WriteLine("Да");
else Console.WriteLine("Нет");
