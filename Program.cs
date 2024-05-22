// Написать программу,
// которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше,
// либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] EnterStringsToArray()
{
    Console.WriteLine("Введите количество строк: ");
    int count = Convert.ToInt32(Console.ReadLine());

    string[] workArray = new string[count];

    if (count == 1)
    {
        Console.WriteLine("Введите 1 строку (после ввода строки нажмите ENTER): ");
    }
    if (count == 2 || count == 3 || count == 4)
    {
        Console.WriteLine($"Введите {count} строки (после ввода строки нажмите ENTER):");
    }
    if (count > 4)
    {
        Console.WriteLine($"Введите {count} строк (после ввода строки нажмите ENTER):");
    }

    for (int i = 0; i < count; i++)
    {
        workArray[i] = Console.ReadLine();
    }
    return workArray;
}

string[] CreatingArrayLessThan3Characters(string[] workArray)
{
    int count = 0;
    foreach (string item in workArray)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }
    string[] result = new string[count];
    int i = 0;
    foreach (string item in workArray)
    {
        if (item.Length <= 3)
        {
            result[i] = item;
            i++;
        }
    }

    return result;
}

string PrintArray(string[] workArray)
{
    string FilterStrings = "[";
    for (int i = 0; i < workArray.Length; i++)
    {
        FilterStrings += $"\"{workArray[i]}\"";
        if (i < workArray.Length - 1)
        {
            FilterStrings += ", ";
        }
    }
    FilterStrings += "]";
    return FilterStrings;
}

string[] workArray = EnterStringsToArray();
string[] result = CreatingArrayLessThan3Characters(workArray);
string array1 = PrintArray(workArray);
string array2 = PrintArray(result);

Console.WriteLine(array1 + " -> " + array2);
