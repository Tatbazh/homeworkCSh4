// Задача 29: Напишите программу, которая задаёт массив из 8
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Введите max до 8 чисел только через запятую: ");
string text = Console.ReadLine()!;

int[] GetArrayFromString(string stringArray, int lengthNubers)
{
    string[] numbers = stringArray.Split(",", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numbers.Length];
    for (int index = 0; index < numbers.Length; index++)
    {
        result[index] = int.Parse(numbers[index]);
    }
    return result;
}

int[] array = GetArrayFromString(text, 8);

if (array.Length > 8)
{
    Console.WriteLine("Введите корректное число символов (не больше 8)");
} 
else 
{
    Console.Write(String.Join(", ", array));
}