// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 12 мин
// 16, 4 -> кратно

Console.WriteLine("Введите число a ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b");
int number2 = Convert.ToInt32(Console.ReadLine());

Multiplicity(number1, number2);

void Multiplicity(int arg1, int arg2)
{
    if (arg1 % arg2 == 0)
    Console.WriteLine(" Число " + arg1 + " кратно " + arg2);
    else 
    Console.WriteLine(" Число " + arg1 + " не кратно " + arg2 + " остаток = " + arg1 % arg2);
}