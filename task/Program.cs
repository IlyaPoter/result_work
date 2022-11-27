void Main()
{
    Console.Clear();
    string[] array = { "hello", "2", "world", ":-)" };

    int volumeArray = VolumeArray(array);
    string[] createArray = CreateArray(volumeArray);
    string[] resultArray = SelectArray(array, createArray);
    PrintArray(resultArray);
}

Main();