// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
int Sum(int collect)
{
    int sum = 0;
    while (collect > 0)
    {
 
        sum = sum + collect % 10;
        collect = collect / 10 ;
    }    
return sum;
}
int number = Promt("Введите число => ");
int result = Sum(number);
Console.WriteLine($"{number} => {result}");