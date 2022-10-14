// Задача 29: Напишите программу, которая задаёт массив из 8
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Введите числа через запятую: ");
string msg = Console.ReadLine();

Console.WriteLine("переводим строку в массив: ");
int[] array = new int [8];

void PrintArray(String[] collection)
{

    int count = collection.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{collection[position]} ");
    }
}
// PrintArray(array);

int SpaceIndex = 0;
int CommaIndex = 0;


string str  = "31, 24, 5, 7, 19";

string s = ""; // для чисел
for () { // цикл по строке поэлементно
    string el = str[i];
    if (el.Equals(",") || el.Equals(" ")) {
     // todo 1 добавить el в массив
    // обнулить el
    el = "";
    } else {
        s = s + el;
    }
}




// int length = str.IndexOf(", ");
// Console.WriteLine(str.Substring(0, length));
// str = str.Substring(str.IndexOf(", ") + 2);
// Console.WriteLine(str);
String[] sa = str.Split();
PrintArray(sa);

// char[] arrayNew = msg.ToCharArray();
// int length = arrayNew.Length;
// for(int index = 0; index < length; index++)
// {

// } 
// Console.WriteLine(arrayNew);