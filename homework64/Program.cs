/*

Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/


// Метод преобразования введенных данных к положительному типу int

int ConvertToAbsInt ( string message)
{
  System.Console.WriteLine(message);
  string str = Console.ReadLine() ?? String.Empty;
  string str1 = str.Replace(" ", "")
                   .Replace(".", ",")
                   .Replace("/", ",");
  double numberDouble = Math.Abs(Convert.ToDouble(str1));
  int numberResult = (int) numberDouble;
  System.Console.WriteLine($"Your number is reduced to {numberResult}");
  return numberResult;
}

// Метод, возвращающий натуральные числа в промежутке от N до 1

void ShowOfNaturalNumbers (int additionLimit)
{
  if (additionLimit == 1)
  {
    System.Console.Write($"{additionLimit}\"");
    return;
  }
  System.Console.Write($"{additionLimit},");
  ShowOfNaturalNumbers(additionLimit-1);
}

// Точка входа в программу

int numberElement = ConvertToAbsInt("Enter the number of the sum of the elements");
System.Console.Write($"Range of natural numbers N = {numberElement} -> \"");
ShowOfNaturalNumbers(numberElement);

