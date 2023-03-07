// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Метод конвертации введенного в консоль сообщения и приведения его к положительному int

int NumberConvertToInt (string message)
{
  Console.WriteLine(message);
  string stringValue = Console.ReadLine() ?? String.Empty;
  double numberValueDouble = Convert.ToDouble(stringValue);
  int numberValueInt = (int) Math.Abs(Convert.ToInt32(numberValueDouble));
  return numberValueInt;
}

// Метод принимает на вход значение размера и создает новый массив

int [] FillArray (int valueArray)
{
  int [] newArray = new int [valueArray];
  for (int i = 0; i < valueArray; i++)
  {
    Console.Write($"{i}: ");
    newArray [i] = Convert.ToInt32(Console.ReadLine());
  }
  return newArray;
}

// Метод выводит массив в консоль

void ShowArray (int [] arrayIn)
{
  System.Console.WriteLine("Your array is:");
  for (int i = 0; i < arrayIn.Length; i++)
  {
    System.Console.Write($"{arrayIn[i]}; ");
  }
  System.Console.WriteLine();
}

// Метод проверяет массив и возвращает количество отрицательных элементов

int numberMinusValues (int [] arrayIn)
{
  int count = 0;
  for (int i = 0; i < arrayIn.Length; i++)
  {
    if (arrayIn [i] < 0)
    {
      count++;
    }
  }
  return count;
}

// Точка входа в функцию

int sizeArray = NumberConvertToInt("Enter size your array, please");
int [] arrayWithSize = FillArray(sizeArray);
ShowArray (arrayWithSize);
System.Console.WriteLine($"Your number minus elements is: {numberMinusValues(arrayWithSize)}");