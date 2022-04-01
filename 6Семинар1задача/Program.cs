// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");

    }
    Console.Write(arr[arr.Length - 1]);
}
int PosNumber(int[] arr)
{
    int count = 0;
    for(int i = 0;i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
return count; 
}
int M = Prompt("Введите задаваемое количество чисел => ");
int[] arr = new int[M];
for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Prompt("Введите число => ");
    }
PrintArray(arr);
Console.WriteLine($" => {PosNumber(arr)}");

