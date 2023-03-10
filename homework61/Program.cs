// Задача 61: Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника

// Конвертация любого отрицательного вещественного числа в положительное типа int
int NumberToAbsInt (string message)
{
    System.Console.WriteLine(message);
    string str = System.Console.ReadLine() ?? String.Empty;
    double resultDouble = Math.Abs(Convert.ToDouble(str));
    int resultInt = (int) resultDouble;
    System.Console.WriteLine($"The entered value is reduced to: {resultInt}");
    return resultInt;
}

// Метод создания треугольника Паскаля
int [,] CreatingMatrix (int sizeRow)
{
  int [,] newMatrix = new int [sizeRow, sizeRow];
  for (int i = 0; i < sizeRow; i++)
  {
    for (int j=0; j < i+1; j++)
    {
      if (j == 0 || j == i)
      {
        newMatrix[i,j] = 1;
        // System.Console.WriteLine($"newMatrix{i},{j} {newMatrix[i,j]}");
      }
      else
      newMatrix[i,j] = newMatrix[i-1,j-1] + newMatrix[i-1,j];
    }
  }
  return newMatrix;
}

// Метод вывода в консоль метода Паскаля
void ShowMatrix (int [,] matrixIn)
{
  for (int i = 0; i < matrixIn.GetLength(0); i++)
  {
      for (int j = 0; j < matrixIn.GetLength(1); j++)
          {
            for (int k = 0; k < matrixIn.GetLength(0)-i; k++)
            {
              if (j == 0)
              System.Console.Write(" ");
              else break;
            }
            if (matrixIn[i,j] == 0)
            System.Console.Write("");
            else
            System.Console.Write($"{Convert.ToString(matrixIn[i,j])} ");
          }
          System.Console.WriteLine();
  }
}



// Точка входа в программу
int numberRow = NumberToAbsInt("Enter the number of rows of the pascal's triangle: ");
int [,] matrixPascal = CreatingMatrix(numberRow);
ShowMatrix(matrixPascal);