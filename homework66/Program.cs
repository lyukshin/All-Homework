/*

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/


// Метод преобразования введенных данных к типу int

int ConvertToAbsInt ( string message)
{
  System.Console.WriteLine(message);
  string str = Console.ReadLine() ?? String.Empty;
  string str1 = str.Replace(" ", "")
                   .Replace(".", ",")
                   .Replace("/", ",");
  double numberDouble = Convert.ToDouble(str1);
  int numberResult = (int) numberDouble;
  System.Console.WriteLine($"Your number is reduced to {numberResult}");
  return numberResult;
}

// Метод, возвращающий сумму натуральные чисел в промежутке от M до N

int SumOfNaturalNumbers (int maximumParametr, int minimumParametr)
{
  if (maximumParametr == minimumParametr)
  {
    return minimumParametr;
  }
  return maximumParametr + SumOfNaturalNumbers(maximumParametr-1, minimumParametr);
}

// Точка входа в программу

int numberMaxElement = ConvertToAbsInt("Enter the maximium number of the sum of the elements");
int numberMinElement = ConvertToAbsInt("Enter the minimum number of the sum of the elements");
if (numberMaxElement < numberMinElement)
{
  int temp = numberMaxElement;
  numberMaxElement = numberMinElement;
  numberMinElement = temp;  
  System.Console.WriteLine($"Your numbers are inverted! MaxElement = {numberMaxElement}, numberMinElement = {numberMinElement}");
}
int sumElements = SumOfNaturalNumbers (
                                        maximumParametr: numberMaxElement,
                                        minimumParametr: numberMinElement
                                                                            );
System.Console.WriteLine($"M = {numberMaxElement}; N = {numberMinElement} -> {sumElements}");