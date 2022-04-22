// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
            Console.Write($"{matrix[i, j]} ");
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
void MinimalLine(int[,] matrix)
{
    int[] lineSum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        lineSum[i] = sum;
    }
    int lowestSum = lineSum[0];
    int indexLowestSum = 0;
    for (int i = 1; i < lineSum.Length; i++)
    {
        if (lineSum[i] < lowestSum)
        {
            lowestSum = lineSum[i];
            indexLowestSum = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов => {indexLowestSum + 1} ");
    Console.WriteLine($"Наименьшая сумма элементов => {lowestSum} ");
}

int i = Prompt("Введите число строк и столбцов => ");
int j = i;
int[,] matrix = CreateDualArray(i, j);
PrintDualArray(matrix);
MinimalLine(matrix);

