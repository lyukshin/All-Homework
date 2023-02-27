// int - 
// double - позволяет работать с вещественными числами
// string - строки от 0 до много символов
// bool - булев тип, true false


// Пример использования int
int numberA = 12;
int numberB = 5;
Console.WriteLine("Пример использования int");
Console.WriteLine(numberA + numberB);
Console.WriteLine(numberA / numberB);
Console.WriteLine();

double numberC = 12;
double numberD = 5;
Console.WriteLine($"Пример использования double");
Console.WriteLine(numberC / numberD);
Console.WriteLine();

// new Random().Next(1,100) - Сгенерировать случайное число от 1 до 100
int numberE = new Random().Next(1,100);
int numberF = new Random().Next(1,100);
Console.WriteLine($"Пример использования Random для числел {numberE} и {numberF}");
Console.WriteLine(numberE + numberF);