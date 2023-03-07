// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Метод возврата числа типа double,введенного в консоли

double NumberConvertToDouble (string message)
{
  Console.WriteLine(message);
  string stringValue = Console.ReadLine() ?? String.Empty;
  return Convert.ToDouble(stringValue);
}

// Метод заполнения массива точками двух прямых

double [] FillArrayDirect ()
{
  double [] arrayDirect = {
                            NumberConvertToDouble ("Enter meaning b1 for the first line: "),
                            NumberConvertToDouble ("Enter meaning k1 for the first line: "),
                            NumberConvertToDouble ("Enter meaning b2 for the second line: "),
                            NumberConvertToDouble ("Enter meaning k2 for the second line: ")
                          };
  return arrayDirect;
}

// Метод проверки на параллельность прямых

bool ParallelismCheck (double [] arrayIn)
{
  if (arrayIn[1] == arrayIn[3])
  {
    System.Console.WriteLine("Your lines are parallel!");
  }
  return arrayIn[1] == arrayIn[3];
}

// Метод нахождения точек пересечения

void ShowIntersectionPoints (double [] arrayIn)
{
  double x = (arrayIn[0]-arrayIn[2])/(arrayIn[3]-arrayIn[1]);
  double y = (arrayIn[1]*x+arrayIn[0]);
  System.Console.Write($"Point of yout intersection of your lines is: {x},{y}");
}

// Точка входа в программу

double [] arrayPointsFunctions = FillArrayDirect ();
if (ParallelismCheck(arrayPointsFunctions))
{
  return;
}
ShowIntersectionPoints (arrayPointsFunctions);