// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int number1 = ReadInt("Введите первое число: ");
int number2 = ReadInt("Введите второе число: ");
MakeDegree(number1, number2);

void MakeDegree(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
    Console.WriteLine($"Результат: {result}");
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}



