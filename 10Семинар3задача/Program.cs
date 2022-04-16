// Задача 3: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя).
// В массиве data хранится информация о количестве бит, которые занимают числа из массива info.
// Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

int BinaryToDecimal(int[] data, int begin, int count)
{
    int temp = 0;
    for (int i = 0; i < count; i++, begin++)
    {
        temp = temp + data[begin] * Stepen(2, count - i - 1);
    }
    return temp;
}
int Stepen(int A, int B)
{
    if (B == 0) return 1;
    return A * Stepen(A, B - 1);
}
void Combine(int[] data, int[] info)
{
    int count = 0;
    int temp = 0;
    for (int i = 0; i < info.Length; i++)
    {
        temp = BinaryToDecimal(data, count, info[i]);
        count = count + info[i];
        Console.Write(temp + " ");
    }
}
int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
Combine(data, info);


    // Рекурсия:
    // void Combine(int[] data, int[] info, int count = 0, int temp = 0)
    // {
    //     if (count >= data.Length) return;
    //     for (int i = 0; i < info.Length; i++)
    //     {
    //         temp = BinaryToDecimal(data, count, info[i]);
    //         count = count + info[i];
    //         Console.Write(temp + " ");
    //     }
    //     Combine(data, info, count, temp);
    // }