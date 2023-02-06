// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int NumBinary(int num)
{
    int binar = 0;
    int count = 1;
    while (num > 0)
    {
        binar = binar + (num % 2 * count);
        num /=2;
        count*=10;
    }
    return binar;
    
        

}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = NumBinary(number);
Console.WriteLine(result);