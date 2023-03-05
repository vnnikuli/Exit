void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}
string[] ModArray(string[] arr)
{
    int k = 0;  
    for (int i = 0; i < arr.Length; i++)    //определение длины нового массива
    {
        if (arr[i].Length <= 3)
        {
            k++;
        }
    }
    string[] new_arr = new string[k];
    k = 0;
    for (int i = 0; i < arr.Length; i++)  // заполнение нового массива
    {
        if (arr[i].Length <= 3)
        {
            new_arr[k] = arr[i];
            k++;
        }
    }

    return new_arr;
}
string[] array = new string[9]
{"Я", "нак", "оне", "ц", "смо", "Г", "2023", "Russia", "jsdfnhskjfsen"};
Console.Write("Исходный массив: ");
PrintArray(array);
string[] arrayNew = ModArray(array);
Console.Write("Новый массив, из элементов исходного, длинной не более 3х символов: ");
PrintArray(arrayNew);