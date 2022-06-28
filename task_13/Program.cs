// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите положительное число:");
int number = Convert.ToInt32(Console.ReadLine());

int Count(int num)
{
    int index = 1;
    while ((num / 10) > 0)
    {
        index = index + 1;
        num = num / 10;
    }
    return index;
}
int bitNumber = Count(number);

if (bitNumber <= 2) Console.WriteLine("Третьей цифры нет");
else if ( bitNumber == 3) Console.WriteLine($"Третья цифра числа {number} => {number%10}");
else
{
    int i = 1;
    int result = number;
    while (i < bitNumber - 2)
    {
        result = result / 10;
        i = i + 1;
    }
    result = result % 10;
    Console.WriteLine($"Третья цифра числа {number} => {result}");
}

