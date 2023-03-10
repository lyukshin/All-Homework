
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


///