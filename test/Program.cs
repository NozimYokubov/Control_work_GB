// Задача: Написать программу, 
// которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

int CountStrings(string[] array, int maxLength)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            size ++;
        }
    }
    return size;
}


string[] CreateArrayStr(string[] array, int maxLength)
{
    int z = CountStrings(array, maxLength);
    string[] NewArray = new string[z];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            NewArray[j++] = array[i];
        }
    }
    return NewArray;
}


string[] array = new string[] { "Hello", "2", "world", ":-)" };
// string[] array = new string[] { "1234", "1567", "-2" };
// string[] array = new string[] { "Russia", "Denmark", "Kazan" };
int mLength = 3;
// int i = CountStrings(array, count);
string[] newArray = CreateArrayStr(array, mLength);
PrintArray(array);
Console.WriteLine();
PrintArray(newArray);