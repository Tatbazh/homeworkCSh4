// Задача 29: Напишите программу, которая задаёт массив из 8
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("1, 2, 5, 7, 19");

string textNumbers = "1, 2, 5, 7, 19";
string Text(string textNumbers, char comma, char interval)
{
    string result = string.Empty;
    int length = textNumbers.Length;
    for (int index = 1; index = length; index++)
    {
        if (textNumbers [index] == comma || textNumbers [index] == interval) 
        result = result + $"{textNumbers[index+1]}";
        else result = result + $"{textNumbers[index]}";
    }     
    return result;
}
string newTextNumbers = Text(textNumbers, ',', ' ');
Console.WriteLine(newTextNumbers);