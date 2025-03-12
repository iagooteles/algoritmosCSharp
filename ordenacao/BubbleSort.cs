int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

Console.WriteLine("Array original:");
PrintArray(arr);

BubbleSort(arr);

Console.WriteLine("\nArray ordenado:");
PrintArray(arr);

static void BubbleSort(int[] arr) 
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

static void PrintArray(int[] arr) 
{
    foreach(var item in arr) 
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}