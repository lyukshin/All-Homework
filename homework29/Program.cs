// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]





int[] Array = new int[8];
Random rnd = new Random(); //подключаем случайные числа


Console.Write("[");
for (int i=0; i<8; i++)
{
Array[i] = rnd.Next(1,99);
Console.Write($"{Array[i]}, ");
}
Console.Write("0]");