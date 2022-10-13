// Задача 27: Напишите функцию и запустите ее, которая
// принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine()!);

int SumNumeral(int numb)
{
    int sum = 0;
    int remainder = 0;
    int number0;
    while (numb != 0)
    {
    number0 = numb / 10;
    remainder = numb % 10;
    numb = number0;
    sum = sum + remainder;
    }
return sum;
}
Console.Write($"Сумма цифр числа {Number} = {SumNumeral(Number)}");