// Задача 4: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateArray(int firstlength, int secondlength, int thirdlength)
{
    int[,,] array = new int[firstlength, secondlength, thirdlength];
    int element = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        element = element + i;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            element = element + j;
            for (int k = 0; k < array.GetLength(2); k++)
            {
                element = element + k;
                array[i, j, k] = element;
            }
        }


    }
    return array;
}
void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++,Console.WriteLine(" "))
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{(i, j, k)}:{matrix[i, j, k]}\t ");
            }
        }
    }
   
}
int[,,] array = CreateArray(3, 3, 4);
PrintArray(array);