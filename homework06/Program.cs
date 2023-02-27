// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number % 2;

if (number1 == 0)
{
 Console.Write($"Число {number} четное");
} else
{
  Console.Write($"Число {number} нечетное");
}