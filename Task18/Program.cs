// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (х и у).

// Console.Write("Введите номер четверти: ");

// int quarter = Convert.ToInt32(Console.ReadLine());

// string result = RangeCoordinates(quarter);

// Console.WriteLine(resutl);

// string RangeCoordinates(int coordinates);
// {
//     if(coordinates == 1) return ("x > 0, y > 0");
//     if(coordinates == 2) return ("x < 0, y > 0");
//     if(coordinates == 3) return ("x < 0, y < 0");
//     if(coordinates == 4) return ("x > 0, y < 0");
//     return ("Введите корректные данные");
// }


Console.Write("Введите номер четверти: ");

string quarter = Console.ReadLine();

string result = RangeCoordinates(quarter);

Console.WriteLine(resutl);

string RangeCoordinates(string coordinates);
{
    if(coordinates == "1") return ("x > 0, y > 0");
    if(coordinates == "2") return ("x < 0, y > 0");
    if(coordinates == "3") return ("x < 0, y < 0");
    if(coordinates == "4") return ("x > 0, y < 0");
    return ("Введите корректные данные");
}