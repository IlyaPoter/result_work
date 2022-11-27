void Main()
{
    Console.Clear();
    string[] array = { "hello", "2", "world", ":-)" };

    int volumeArray = VolumeArray(array);
    string[] createArray = CreateArray(volumeArray);
    string[] resultArray = SelectArray(array, createArray);
    PrintArray(resultArray);
}

int VolumeArray(string[] arr) // определение количества элементов в новом массиве
{
    int volumeArray = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            volumeArray++;
        }
    }
    return volumeArray;
}

string[] CreateArray(int volumeArr) // создание массива для заполнения необходимой длины
{
    string[] createArray = new string[volumeArr];
    return createArray;
}

string[] SelectArray(string[] array, string[] resultArray) // заполнение созданного массива, заданной размерности, строками длиной <= 3
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;
}

void PrintArray(string[] arr) // печать массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
Main();