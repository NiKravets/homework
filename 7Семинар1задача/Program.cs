// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void FillArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble() + new Random().Next(-100, 100);
            Console.Write("{0,6:F1}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
int m = Prompt("Введите число m => ");
int n = Prompt("Введите число n => ");
double[,] matrix = new double[m, n];
FillArray(matrix);
