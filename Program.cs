string? yesNo = string.Empty;
while (yesNo.ToLower() != "yes" && yesNo.ToLower() != "no")
{
    Console.Write("Do you want to enter string manually? (yes/no): ");
    yesNo = Console.ReadLine();
}

string[] arrayOfStrings = new string[] { };
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
if (yesNo.ToLower() == "yes")
{
    int n = InputNumbers("Enter number of array elements: ");
    arrayOfStrings = new string[n];
    for (int i = 0; i < arrayOfStrings.Length; i++)
    {
        Console.Write($" Enter {i + 1} string: ");
        arrayOfStrings[i] = Console.ReadLine();
    }
}
else
{
    arrayOfStrings = new string[] { "hello", "2", "world", ":-)" };
}
void CreateNewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
    int temp = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= lengthLimit)
        {
            newArray[temp] = oldArray[i];
            temp++;
        }
    }
}

int CheckingArray(string[] array, int lengthLimit)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthLimit) result++;
    }
    return result;
}

string PrintArray(string[] array)
{
    string result = string.Empty;
    result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i],1}";
        if (i < array.Length - 1) result += ", ";
    }
    result += " ]";
    return result;
}
int lengthLimit = 3;

int numbersItems = CheckingArray(arrayOfStrings, lengthLimit);

string[] newArrayOfStrings = new string[numbersItems];

CreateNewArray(arrayOfStrings, newArrayOfStrings, lengthLimit);

Console.WriteLine($"{PrintArray(arrayOfStrings)} - > {PrintArray(newArrayOfStrings)}");
