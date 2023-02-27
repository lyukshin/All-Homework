// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int check = number % 2;
int temp = 2;

if (check == 0)
{
    while(temp < number)
    {
    Console.Write($"{temp} ");
    temp = temp + 2;
    }
} else
{
while(temp < number)
    {
    Console.Write($"{temp} ");
    temp = temp + 2;
    }
}