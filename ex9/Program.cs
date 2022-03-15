// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.(строка)
Console.Write("Введите пятизначное число: ");
string strValue = Console.ReadLine();
int N = strValue.Length;
bool b = true;
if(N != 5) Console.WriteLine("Число не пятизначное");

   for (int i = 0; i < N / 2; i++)
   {
      if (strValue[i] != strValue[N - 1 - i])
      {
         b = false;
         break;
      }
   }
Console.WriteLine(b ? "Число является палиндромом" : "Число не является палиндромом");

// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.(масив)
/* Console.WriteLine("Заполните масив: ");
int N = 5;
int[] array = new int[N];
     for (int i = 0; i < N; i++)
    {
         int k = Int32.Parse(Console.ReadLine()); 
         array[i] = k;
        
    }
Console.WriteLine(string.Join("," , array)); 
bool b = true;
   for (int i = 0; i < N / 2; i++)
   {
      if (array[i] != array[N - 1 - i])
      {
         b = false;
         break;
      }
   }
Console.WriteLine(b ? "Число является палиндромом" : "Число не является палиндромом"); */