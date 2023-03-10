/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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

// Заполнение матрицы согласно размерам, введенным пользователем с генерацией чисел от 0 до 9
int [,] CreatingMatrix (int valueRow, int valueColl)
{
    int [,] newMatrix = new int [valueRow, valueColl];
    Random rnd = new Random();
    for (int i = 0; i < valueRow; i++)
    {
        for (int j = 0; j < valueColl; j++)
        {
            newMatrix[i,j] = rnd.Next(0,4);
        }
        System.Console.WriteLine();
    }
    return newMatrix;
}

//Метод, выводит в консоль матрицу, заполненную целыми числами

void ShowRealMatrix (int [,] matrixIn)
{
  System.Console.WriteLine("Your matrix filled withrandom integer numbers:");
  for (int i = 0; i < matrixIn.GetLength(0); i++)
  {
    for (int j = 0; j < matrixIn.GetLength(1); j++)
    {
      System.Console.Write($"{matrixIn[i,j]}\t");
    }
    System.Console.WriteLine();
  }
}

// Метод, возвращающий произведение матриц
int [,] MatrixMultiplication (int [,] matrixFirst, int [,] matrixSecond)
{
  int [,] useMatrixMultiplication = new int [matrixFirst.GetLength(0), matrixSecond.GetLength(1)];
  for (int i = 0; i < matrixFirst.GetLength(0); i++)
  {
      for (int j = 0; j < matrixSecond.GetLength(1); j++)
      {
        for (int k = 0; k < matrixFirst.GetLength(1); k++)
        {
          useMatrixMultiplication [i,j] += matrixFirst[i,k]*matrixSecond[k,j];
          // System.Console.Write($"First = {i}|{k} {matrixFirst[i,k]} Second = {k}|{j} {matrixSecond[k,j]} \t");
          // System.Console.WriteLine($"i = {i} j = {j} {useMatrixMultiplication[i,j]}");
        }
      }
  }
  return useMatrixMultiplication;
}

// Точка входа в программу
int useRowsFirstNumber = NumberToAbsInt("Enter the number of rows of the first matrix: ");
int useColumnsFirstNumber = NumberToAbsInt("Enter the number of columns of the first matrix: ");
int [,] useFirstMatrix = CreatingMatrix ( valueRow:useRowsFirstNumber,
                                          valueColl:useColumnsFirstNumber);
int useRowsSecondNumber = NumberToAbsInt("Enter the number of rows of the second matrix: ");
int useColumnsSecondNumber = NumberToAbsInt("Enter the number of columns of the second matrix: ");
int [,] useSecondMatrix = CreatingMatrix (valueRow:useRowsSecondNumber,
                                          valueColl:useColumnsSecondNumber);
ShowRealMatrix(useFirstMatrix);
System.Console.WriteLine();
ShowRealMatrix(useSecondMatrix);
System.Console.WriteLine();                                            
if (useColumnsFirstNumber != useRowsSecondNumber)
{
  System.Console.WriteLine("Error! Your matrices are out of proportion!");
  return;
}
ShowRealMatrix(MatrixMultiplication (
                                    matrixFirst: useFirstMatrix,
                                    matrixSecond: useSecondMatrix
                                                              ));