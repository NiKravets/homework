// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
string strValue = Console.ReadLine();
int length = strValue.Length;

if(length > 2) Console.WriteLine(strValue[2]);
else Console.WriteLine("Третьей цифры нет");
