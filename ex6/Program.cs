// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
Random rnd = new Random();
int number = rnd.Next(100, 1000);
string Value = number.ToString();

Console.WriteLine($"Число {Value} Удаление второй цифры числа {Value[0]}{Value[2]}");

