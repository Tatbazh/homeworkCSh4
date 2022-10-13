// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B. Реализовать функцию возведения в степень
// самостоятельно!
// 3, 5 -> 243 (3⁵)   2, 4 -> 16
Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);

int Degree(int A, int B)
{
    int result = 1;
    for (int index = 1; index <= B; index++)
    {
    result = result * A;
    }
    return result;
}
//Console.WriteLine(Degree(numberA, numberB));
Console.Write($"число А ->{numberA} в степени B->{numberB} = {Degree(numberA, numberB)}");
