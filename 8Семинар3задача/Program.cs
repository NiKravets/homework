// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
            Console.Write($"{matrix[i, j]}\t ");
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
int[,] Multiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
        for (int j = 0; j < matrixB.GetLength(0); j++)
            for (int k = 0; k < matrixB.GetLength(1); k++)
                matrixC[i, k] += matrixA[i, j] * matrixB[j, k];
    return matrixC;
}

int i = Prompt("Введите число строк => ");
int j = Prompt("Введите число столбцов => ");
int[,] matrixA = CreateDualArray(i, j);
PrintDualArray(matrixA);
int p = Prompt("Введите число строк => ");
int k = Prompt("Введите число столбцов => ");
int[,] matrixB = CreateDualArray(p, k);
PrintDualArray(matrixB);
Console.WriteLine();
int[,] matrixC = Multiplication(matrixA, matrixB);
PrintDualArray(matrixC);



