// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] RandArray(int lenght)
{

    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(10, 100);
    }
    return answer;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");

    }
    Console.Write(arr[arr.Length - 1] + "]");
}
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
int SumOdd(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}
int len = Prompt("Введите длину массива => ");
int[] arr = RandArray(len);
PrintArray(arr);
Console.WriteLine($" => {SumOdd(arr)}");
