// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine("Введите трехзначное число ");
// int number = Convert.ToInt32(Console.ReadLine());
 
// int res = ShowSecond(number);

// Console.WriteLine($"результат -> {res}");
 
// int ShowSecond(int num);
// { 
//     int num = 
//     int result = ((num / 10) % 10);
//     return result;
// }

Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int lengh = number.ToString().Length;

if (lengh < 3 || lengh > 3)
Console.WriteLine("Это не трехзначное число! ");
else
Console.WriteLine("Вторая цифра - это ");


int res = SecondDigit(number);

 Console.WriteLine($"результат -> {res}");
 
int SecondDigit(int num)
{ 
    int result = ((num / 10) % 10);
    return result;
}