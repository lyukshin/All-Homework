
int[] numbers = { 2, 5, 13, 7, 6, 4 };
int size = 6;
int sum = 0;
int avg = 0;
int index = 0;

while (index < size)
    {
    sum = sum + numbers[index];
    index = index +1;
    }

avg = sum / size;

Console.WriteLine($"{avg}");