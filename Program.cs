string[] arrString = GetUserArrayString(5);
string[] arrNewSrting = GetArrayNewString(arrString);
PrintArray(arrString);
Console.Write(" -> ");
PrintArray(arrNewSrting);

string[] GetUserArrayString(int arrLength)
{
    string[] array = new string[arrLength];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите значение {i + 1} ячейки");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

string[] GetArrayNewString(string[] arr)
{
    int stringCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) stringCount += 1;
    }
    string[] newArray = new string[stringCount];
    int newArrayIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArray[newArrayIndex] = arr[i];
            newArrayIndex++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    Console.Write($"[{String.Join(", ", array)}]");
}