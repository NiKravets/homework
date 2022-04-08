// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
            Console.Write(matrix[i, j] + "\t");
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
void FindValue(int[,] matrix, int i1, int j1)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == i1 - 1 && j == j1 - 1) Console.WriteLine(matrix[i, j]);
        }
    }
    if (1 > i1 || i1 > matrix.GetLength(0) || 1 > j1 || j1 > matrix.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
}
int m = Prompt("Введите число строк => ");
int n = Prompt("Введите число столбцов => ");
int[,] matrix = new int[m, n];
FillArray(matrix);
int i = Prompt("Введите позицию в строке => ");
int j = Prompt("Введите позицию в столбце => ");
FindValue(matrix, i, j);
