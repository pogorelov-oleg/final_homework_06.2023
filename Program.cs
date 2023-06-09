string[] arrString = GetUserArrayString(5);
string[] arrNewSrting = GetArrayNewString(arrString);
PrintArray(arrString);
Console.Write(" -> ");
PrintArray(arrNewSrting);

string[] GetArrayString(int arrLength)
{
    string[] array = new string[arrLength];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите значение {i + 1} ячейки");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write($"[{String.Join(", ", array)}]");
}