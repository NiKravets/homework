// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76
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
int MinN(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}
int MaxN(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}

int len = Prompt("Введите длину массива => ");
int[] arr = RandArray(len);
PrintArray(arr);
Console.WriteLine($" => {MaxN(arr) - MinN(arr)}");