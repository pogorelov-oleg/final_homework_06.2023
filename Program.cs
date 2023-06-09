string[] arrString = GetUserArrayString(5);
string[] arrNewSrting = GetArrayNewString(arrString);
PrintArray(arrString);
Console.Write(" -> ");
PrintArray(arrNewSrting);

void PrintArray(string[] array)
{
    Console.Write($"[{String.Join(", ", array)}]");
}