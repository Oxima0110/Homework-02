int number = new Random().Next(100, 1000);
int result = (number/10) % 10;
Console.WriteLine($"Вторая цифра числа {number} => {result}");

