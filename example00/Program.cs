

string[] CreatrArrayString()
{
    Console.Write("Введите число для определения размера массива  ");
    int arg = Convert.ToInt32(Console.ReadLine());

    string[] arr = new string[arg];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите строку  ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

string[] array = CreatrArrayString();


string[] Sorting(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length >= 3) count++;
    }

    string[] newArr = new string[count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length >= 3)
        {
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
PrintArray(array);
Console.Write(" -> ");


string[] newArray = Sorting(array);
PrintArray(newArray);