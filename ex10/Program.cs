// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    double Value = double.Parse(strValue);
    return Value;
}

double x1 = Prompt("Введите x первой точки =>");
double y1 = Prompt("Введите y первой точки =>");
double z1 = Prompt("Введите z первой точки =>");
double x2 = Prompt("Введите x второй точки =>");
double y2 = Prompt("Введите y второй точки =>");
double z2 = Prompt("Введите z второй точки =>");
double x3 = x2 - x1;
double y3 = y2 - y1;
double z3 = z2 - z1;
double d = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2) + Math.Pow(z3, 2));

Console.WriteLine(d);
