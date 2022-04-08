// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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
void AverageColumn(int[,] matrix)
{
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if(i < matrix.GetLength(0)-1)
            {
                average = average + matrix[i,j];
            }
            else average = (average + matrix[i,j])/matrix.GetLength(0);
        }
        Console.Write(average + "; ");
        
    }
}
int m = Prompt("Введите число строк => ");
int n = Prompt("Введите число столбцов => ");
int[,] matrix = new int[m, n];
FillArray(matrix);
AverageColumn(matrix);