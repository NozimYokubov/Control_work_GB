// // Задача: Написать программу, 
// // которая из имеющегося массива строк формирует новый массив из строк, 
// // длина которых меньше, либо равна 3 символам. 
// // Первоначальный массив можно ввести с клавиатуры, 
// // либо задать на старте выполнения алгоритма. 
// // При решении не рекомендуется пользоваться коллекциями, 
// // лучше обойтись исключительно массивами.

// // Примеры:
// // [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// // [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// // [“Russia”, “Denmark”, “Kazan”] → []


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

// bool AreThereEnoughSymbolsInStr(string str, int test)
// {
//      if (str.Length < test)
//     {
//         return true;
//     } 
//     return false;
// }

// int HowManyStrHas3SymbolsInArray(string[] array)
// {
//     int size = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (AreThereEnoughSymbolsInStr(array[i]))
//         {
//             size += 1;
//         }
//     }
//     return size;
// }


// string[] CreateArrayStr(string[] array)
// {
    
//     string[] NewArray = new string[HowManyStrHas3SymbolsInArray(array)];
//     for (int i = 0; i < array.GetLength; i++)
//     {
//         int j = 0;
//         if (AreThereEnoughSymbolsInStr(array[i]))
//         {
//             NewArray[j] = array[i];
//             j += 1;
//         }
//     }
// }


// // Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// // Сформировать строку, в которой слова расположены в обратном порядке. 
// // В полученной строке слова должны быть также разделены пробелами.

// // “Hello my world” => “world my Hello”

// string hello = "Hello my world";
// string res = string.Empty;
// string[] helloSplit = hello.Split();//["Hello", "my", "world"]

// for (int i = helloSplit.Length - 1; i >= 0; i--)
// {
//     res += helloSplit[i] + " ";
// }

// Console.WriteLine(res.TrimEnd());



bool AreThereEnoughSymbolsInStr(string str, int test)
{
     if (str.Length < test)
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
    for (int i = 0; i < array.Length; i++)
    {
        int j = 0;
        if (AreThereEnoughSymbolsInStr(array[i], test))
        {
            NewArray[j] = array[i];
            j += 1;
        }
    }
    return NewArray;
}

// bool result = AreThereEnoughSymbolsInStr(i, 5);

// Console.WriteLine(result ? i : "В строке больше трех символов");




// string i = "What";
string[] array = new string[] { "one", "two", "three" };
int count = 4;
int i = HowManyStrHas3SymbolsInArray(array, count);
string[] newArray = CreateArrayStr(array, count);
PrintArray(newArray);