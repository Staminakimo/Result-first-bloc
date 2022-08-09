string[] sourceArray = new string[5] { "Спc", "за новые", "интересные", "знания", "Бро" };
string[] newArray = new string[sourceArray.Length];
void Array(string[] sourceArray, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < sourceArray.Length; i++)
    {
        if (sourceArray[i].Length <= 3)
        {
            newArray[count] = sourceArray[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Array(sourceArray, newArray);
PrintArray(newArray);

