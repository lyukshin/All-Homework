/*

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/


// Метод преобразования введенных данных к положительному типу int

double ConvertToAbsInt ( string message)
{
  System.Console.WriteLine(message);
  string str = Console.ReadLine() ?? String.Empty;
  string str1 = str.Replace(" ", "")
                   .Replace(".", ",")
                   .Replace("/", ",");
  double numberDouble = Math.Abs(Convert.ToDouble(str1));
  System.Console.WriteLine($"Your number is reduced to {numberDouble}");
  return numberDouble;
}

// Метод вычисления функции Аккермана с помощью рекурсии

double AckermanFunction (double m, double n)
{
  if (m == 0)
  {
    return n+1;
  }
  if (n == 0)
  {
    return AckermanFunction(m - 1, 1);
  }
  return AckermanFunction(m - 1, AckermanFunction(m, n-1));
}

// Точка входа в программу

double numberMFunctionAckerman = ConvertToAbsInt("Enter the number M of the Ackerman function");
double numberNFunctionAckerman = ConvertToAbsInt("Enter the number N of the Ackerman function");

double sumElements = AckermanFunction (
                                        m: numberMFunctionAckerman,
                                        n: numberNFunctionAckerman
                                                                            );
System.Console.WriteLine($"m = {numberMFunctionAckerman}; n = {numberNFunctionAckerman} -> A(m,n) = {sumElements}");
