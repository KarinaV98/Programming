// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int number = ReadInt("Введите число: ");
int length = NumberLength(number);
SumNumbers(number, length);
int ReadInt(string message)

{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberLength(int numlen)
{
    int index = 0;
    while (numlen > 0)
    {
        numlen /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int num, int length)
{
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    Console.WriteLine($"Сумма чисел: {sum}");
}