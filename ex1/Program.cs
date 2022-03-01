//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите число 1: ");
string strValue1 = Console.ReadLine();
int Value1 = int.Parse(strValue1);

Console.Write("Введите число 2: ");
string strValue2 = Console.ReadLine();
int Value2 = int.Parse(strValue2);

if(Value1 > Value2)
{
    Console.WriteLine("Число 1 больше числа 2");
}
if(Value1 < Value2)
{
    Console.WriteLine("Число 2 больше числа 1");
}
if(Value1 == Value2)
{
    Console.WriteLine("Число 1 и число 2 равны");
}
