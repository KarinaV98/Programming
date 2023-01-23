// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число, обозначающее день недели");
int number = Convert.ToInt32(Console.ReadLine());



if (number < 1 || number > 7)
{
    Console.WriteLine("Вы ввели неверное число!");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine("Ура, выходной!");
}
else
{
    Console.WriteLine("Придется идти на работу(");
}