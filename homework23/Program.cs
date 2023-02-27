
// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



 System.Console.Write("Введите число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine($"Таблица кубов от 1 до {number}");

 for (int i = 1; i <= number; i++)// i = i + 2
 {
     System.Console.Write($"{Math.Pow(i, 3)} ");
 }