
void FillArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100000).ToString();
    }
}

string [] FilterFor3Char(string[] array)
{
    string[] resultArray = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            resultArray[count] = array[i];
            count++;
        }
    }
    return resultArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] primaryArray = new string[new Random().Next(1, 10)];

FillArray(primaryArray);
PrintArray(primaryArray);
PrintArray(FilterFor3Char(primaryArray));

