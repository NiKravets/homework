﻿// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
double Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    double Value = double.Parse(strValue);
    return Value;
}
double k1 = Prompt("Введите число => ");
double b1 = Prompt("Введите число => ");
double k2 = Prompt("Введите число => ");
double b2 = Prompt("Введите число => ");
double x = (b2-b1)/(k1-k2);
double y = k1 * x + b1;
Console.WriteLine($"({x}, {y})");
