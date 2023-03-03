// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

// МЕТОД. На вход принимает размер, создает и возвращает массив указанной рамерности 
// случайными числами. Специально указал в диапазоне -9 до 10 для наглядности
int [] FillDigitPositiveArray (int sizeArray)
{
  int [] fillArray = new int [sizeArray];
  Random rnd = new Random();
  for (int i = 0; i < sizeArray; i++)
  {
    fillArray[i] = rnd.Next(-9, 10);
  }
  return fillArray;
}

// МЕТОД. На вход принимает массив и возвращает сумму элементов, стоящих на нечетных позициях индексов. 
int SumOfElementsOfOddIndeces (int [] ArrayIn) // по условию массив с нулем элементов к нам не зайдет при создании
{
  int sum = 0;
  for (int i = 1; i < ArrayIn.Length; i+=2) // итерацией +2 двигаемся только по нечетным позициям индексов
  {
    sum += ArrayIn[i];
  }
  return sum;
}

// Точка входа в программу
int sizeArray = Promt ("Enter the size your array");
int [] newArray = FillDigitPositiveArray(sizeArray);
System.Console.WriteLine(string.Join("; ", newArray));
System.Console.WriteLine($"Sum of element of odd indeces is {SumOfElementsOfOddIndeces(newArray)}");