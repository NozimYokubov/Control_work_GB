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

bool AreThereEnoughSymbolsInStr(string str, int test)
{
     if (str.Length < test + 1)
    {
        return true;
    } 
    return false;
}

int HowManyStrHas3SymbolsInArray(string[] array, int test)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (AreThereEnoughSymbolsInStr(array[i], test))
        {
            size += 1;
        }
    }
    return size;
}


string[] CreateArrayStr(string[] array, int test)
{
    int z = HowManyStrHas3SymbolsInArray(array, test);
    string[] NewArray = new string[z];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (AreThereEnoughSymbolsInStr(array[i], test))
        {
            NewArray[j] = array[i];
            j += 1;
        }
    }
    return NewArray;
}


// string[] array = new string[] { "Hello", "2", "world", ":-)" };
// string[] array = new string[] { "1234", "1567", "-2" };
string[] array = new string[] { "Russia", "Denmark", "Kazan" };
int count = 3;
// int i = HowManyStrHas3SymbolsInArray(array, count);
string[] newArray = CreateArrayStr(array, count);
PrintArray(array);
Console.WriteLine();
PrintArray(newArray);