// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

// [3 7 22 2 78] -> 76

// МЕТОД. Принимает сообщение, выводит его в консоль, считывает введенные данные в консоль 
// (любое положительное и отрицательное вещественное и целое число), приводит их к целому
// положительному числу без остатка и возвращает как результат своей работы туда, где вызвали сей метод;
int Promt (string message)
{
  System.Console.WriteLine(message);
  string str = System.Console.ReadLine() ?? String.Empty;
  double numberDouble = (int) Convert.ToDouble(str);
  int result = (int) Math.Abs(Convert.ToInt32(numberDouble));
  if (result == 0)
  {
    System.Console.WriteLine("You specified an insufficient array size!");
    return -1;
  }
  return result;
}

// МЕТОД. На вход принимает размер, создает и возвращает массив вещественных чисел
// для наглядности - в диапазоне двух разрядностей целых и вещественных чисел 

double [] PaddingWithRealNumbers (int sizeArray)
{
  double [] fillArray = new double [sizeArray];
  Random rnd = new Random();
  for (int i = 0; i < sizeArray; i++)
  {
    fillArray[i] = rnd.Next(-99,100) + Math.Round(rnd.NextDouble(), 2);
  }
  return fillArray;
}

// МЕТОД. На вход принимает массив и возвращает разницу между максимальным
// и минимальным значениями элементов индекса массива. 

double DifferenceMaxMinValue (double [] ArrayIn)
{
  double maxElement = ArrayIn[0];
  double minElement = ArrayIn[0];
  if (ArrayIn.Length == 1)
  {
    System.Console.WriteLine("Not enough array elements!");
    return -1;
  }

  for (int i = 0; i < ArrayIn.Length; i++)
  {
    if (maxElement<ArrayIn[i])
    {
      maxElement = ArrayIn[i];
    }
    if (minElement>ArrayIn[i])
    {
      minElement = ArrayIn[i];
    }
  }
  System.Console.WriteLine($"Your maximum value is: {maxElement}");
  System.Console.WriteLine($"Your minimum value is: {minElement}");
  return maxElement-minElement;
}

// Точка входа в программу
int sizeDoubleArray = Promt ("Enter the size your array");
double [] newArray = PaddingWithRealNumbers(sizeDoubleArray);
System.Console.WriteLine(string.Join("; ", newArray));
System.Console.WriteLine($"Difference betweeen values is: {DifferenceMaxMinValue(newArray)}");