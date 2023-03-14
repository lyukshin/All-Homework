
// Метод заполнения двумерного массива
int [,] FillDoubleArray (int m, int n)

{
    int [,] newDoubleArray = new int [m, n];
    
    for (int i = 0; i < newDoubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < newDoubleArray.GetLength(1); j++)
        {
            newDoubleArray [i,j] = i+j;
        }
    }
    return  newDoubleArray;
}

// Метод вывода массива
void ShowDoubleArray (int [,] arrayIn)

{   
    for (int i = 0; i < arrayIn.GetLength(0); i++)
    {
        for (int j = 0; j < arrayIn.GetLength(1); j++)
        {
            System.Console.Write($"{arrayIn [i,j]}; ");
        }
    }   
}


System.Console.WriteLine("Enter your number row");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter your number column");
int n = Convert.ToInt32(Console.ReadLine());
int [,] userArray = FillDoubleArray (m, n);
ShowDoubleArray (userArray);


Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29