// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] CreateDualArray(int line, int column)
{
    int[,] matrix = new int[line, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
        }
    }
    return matrix;
}
void PrintDualArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
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
void ArrayMaxToMinInStr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int maxindex = j;
            for (int k = j; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i, maxindex]) maxindex = k;
            }
            if (matrix[i, j] == matrix[i, maxindex]) continue;
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, maxindex];
            matrix[i, maxindex] = temp;
        }
    }
}

int i = Prompt("Введите число строк => ");
int j = Prompt("Введите число столбцов => ");
int[,] matrix = CreateDualArray(i,j);
PrintDualArray(matrix);
ArrayMaxToMinInStr(matrix);
Console.WriteLine();
PrintDualArray(matrix);