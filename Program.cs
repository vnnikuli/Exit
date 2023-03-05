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
