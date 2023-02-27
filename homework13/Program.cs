// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


// int number = new Random().Next(100, 100000); 
// Console.WriteLine($"Ваше случайное число: {number}");

if (number < 100)
{
    Console.WriteLine($"Третьей цифры нет");
}
else if (number >= 100 && number < 1000 )
{
int digit1 = number%10;
Console.WriteLine($"Итоговое число: {digit1}");
}
else if (number >= 1000 && number < 10000 )
{
int digit2 = number%100;
int digit3 = digit2/10;
Console.WriteLine($"Итоговое число: {digit3}");
}
else if (number >= 10000 && number < 100000 )
{
int digit4 = number%1000;
int digit5 = digit4/100;
Console.WriteLine($"Итоговое число: {digit5}");
}

else
{
Console.WriteLine($"Число превышает пример из задачи");

}