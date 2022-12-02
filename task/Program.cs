Console.Clear();
void FillArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10000).ToString();
    }
}

string [] FilterFor3Char(string[] array)
{
    int length = 0;
    for(int i = 0; i < array.Length; i++) 
    {
        if(array[i].Length <= 3) 
        {
            length++;
        }
    }

    string[] resultArray = new string[length];
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

string[] primaryArray = new string[new Random().Next(8, 24)];

FillArray(primaryArray);
FilterFor3Char(primaryArray);
Console.WriteLine($"[{string.Join(", ", primaryArray)}] -> [{string.Join(", ", FilterFor3Char(primaryArray))}]");

