/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
using System.Threading;

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

void FillToTheRight (                                            // Вправо
                          ref int [,] matrixFillRight,
                          int upRowRight,
                          int belowRowRight,
                          int leftColumnRight,
                          int rightColumnRight,
                          int countRight
                                                    ) 
{
  if (upRowRight <= belowRowRight && leftColumnRight <= rightColumnRight) 
  {      
    for (int j = leftColumnRight; j <= rightColumnRight; j++)
    {
        matrixFillRight[upRowRight,j] = countRight;
        // System.Console.Write($"{matrixFillRight[upRowRight,j]}\t");
        // Thread.Sleep(200);
        countRight++;
    }
  }
  upRowRight++;
  if (upRowRight <= belowRowRight && leftColumnRight <= rightColumnRight) 
  {
    FillToTheDown(                                            // Вниз
                          matrixFillDown :  ref matrixFillRight,
                          upRowDown      :  upRowRight,
                          belowRowDown   :  belowRowRight,
                          leftColumnDown :  leftColumnRight,
                          rightColumnDown:  rightColumnRight,
                          countDown      :  countRight
                                                              );
  }  
  else
  return;
}


void FillToTheDown (                                            // Вниз
                        ref int [,] matrixFillDown,
                        int upRowDown,
                        int belowRowDown,
                        int leftColumnDown,
                        int rightColumnDown,
                        int countDown
                                                    ) 
{
  if (upRowDown <= belowRowDown && leftColumnDown <= rightColumnDown) 
  {      
    for (int i = upRowDown; i <= belowRowDown; i++)
    {
      matrixFillDown[i,rightColumnDown] = countDown;
      // System.Console.WriteLine($"{matrixFillDown[i,rightColumnDown]}");
      // Thread.Sleep(500);
      countDown++;
    }
  }
  rightColumnDown--;
  if (upRowDown <= belowRowDown && leftColumnDown <= rightColumnDown) 
  {
    FillToTheLeft(                                            // Влево
                          matrixFillLeft :  ref matrixFillDown,
                          upRowLeft      :  upRowDown,
                          belowRowLeft   :  belowRowDown,
                          leftColumnLeft :  leftColumnDown,
                          rightColumnLeft:  rightColumnDown,
                          countLeft      :  countDown
                                                              );
  }
  else
  return;
}

void FillToTheLeft (                                            // Влево
                          ref int [,] matrixFillLeft,
                          int upRowLeft,
                          int belowRowLeft,
                          int leftColumnLeft,
                          int rightColumnLeft,
                          int countLeft
                                                    ) 
{
  if (upRowLeft <= belowRowLeft && leftColumnLeft <= rightColumnLeft) 
  {      
    for (int j = rightColumnLeft; j >= leftColumnLeft; j--)
    {
        matrixFillLeft[belowRowLeft,j] = countLeft;
        // System.Console.Write($"{matrixFillLeft[belowRowLeft,j]}\t");
        // Thread.Sleep(200);
        countLeft++;
    }
  }
  belowRowLeft--;
  if (upRowLeft <= belowRowLeft && leftColumnLeft <= rightColumnLeft) 
  {
    FillToTheUp(                                            // Вверх
                          matrixFillUp :  ref matrixFillLeft,
                          upRowUp      :  upRowLeft,
                          belowRowUp   :  belowRowLeft,
                          leftColumnUp :  leftColumnLeft,
                          rightColumnUp:  rightColumnLeft,
                          countUp      :  countLeft
                                                            );
    // Функция - вниз!!
  }
  else
  return;
}

void FillToTheUp (                                            // Вверх
                        ref int [,] matrixFillUp,
                        int upRowUp,
                        int belowRowUp,
                        int leftColumnUp,
                        int rightColumnUp,
                        int countUp 
                                                    ) 
{
  if (upRowUp <= belowRowUp && leftColumnUp <= rightColumnUp) 
  {      
    for (int i = belowRowUp; i >= upRowUp; i--)
    {
      matrixFillUp[i,leftColumnUp] = countUp;
      // System.Console.WriteLine($"{matrixFillUp[i,leftColumnUp]}");
      // Thread.Sleep(500);
      countUp++;
    }
  }
  leftColumnUp++;
  if (upRowUp <= belowRowUp && leftColumnUp <= rightColumnUp) 
  {
    FillToTheRight  (
                              matrixFillRight :  ref matrixFillUp,
                              upRowRight      :  upRowUp,
                              belowRowRight   :  belowRowUp,
                              leftColumnRight :  leftColumnUp,
                              rightColumnRight:  rightColumnUp,
                              countRight      :  countUp
                                                                  );
  // Функция - вправо!!
  } 
  else
  return; 
}


int [,] SpiralFillingMatrix (int valueRow, int valueColl)
{
    int [,] newMatrix = new int [valueRow, valueColl];
    int numberRowUp = 0;
    int numberRowBelow = valueRow-1;
    int numberColumnLeft = 0;
    int numberColumnRight = valueColl-1;
    int count = 0;
    FillToTheRight (
                              matrixFillRight :  ref newMatrix,
                              upRowRight      :  numberRowUp,
                              belowRowRight   :  numberRowBelow,
                              leftColumnRight :  numberColumnLeft,
                              rightColumnRight:  numberColumnRight,
                              countRight      :  count
                                                              );
    
    
    return newMatrix;
}

//Метод, выводит в консоль матрицу, заполненную целыми числами

void ShowSpiralMatrix (int [,] matrixIn)
{
  System.Console.WriteLine("Your matrix filled withrandom integer numbers:");
  for (int i = 0; i < matrixIn.GetLength(0); i++)
  {
    for (int j = 0; j < matrixIn.GetLength(1); j++)
    {
      System.Console.Write($"{matrixIn[i,j]}\t");
      Thread.Sleep(100);
    }
    System.Console.WriteLine();
  }
}


// Точка входа в программу
int useRowsNumber = NumberToAbsInt("Enter the number of rows of the matrix: ");
int useColumnsNumber = NumberToAbsInt("Enter the number of columns of the matrix: ");
int [,] useMatrix = SpiralFillingMatrix ( 
                                          valueRow:useRowsNumber,
                                          valueColl:useColumnsNumber
                                                                      );
ShowSpiralMatrix(useMatrix);
